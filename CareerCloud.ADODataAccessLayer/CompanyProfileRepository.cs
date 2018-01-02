using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.SqlClient;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyProfileRepository :BaseClass,IDataRepository<CompanyProfilePoco>
    {
        public void Add(params CompanyProfilePoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (CompanyProfilePoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Company_Profiles]
                                                           ([Id]
                                                           ,[Registration_Date]
                                                           ,[Company_Website]
                                                           ,[Contact_Phone]
                                                           ,[Contact_Name]
                                                           ,[Company_Logo])
                                                     VALUES
                                                           (@Id
                                                           ,@Registration_Date
                                                           ,@Company_Website
                                                           ,@Contact_Phone
                                                           ,@Contact_Name
                                                           ,@Company_Logo)";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Registration_Date", item.RegistrationDate);
                    cmd.Parameters.AddWithValue("@Company_Website", item.CompanyWebsite);
                    cmd.Parameters.AddWithValue("@Contact_Phone", item.ContactPhone);
                    cmd.Parameters.AddWithValue("@Contact_Name", item.ContactName);
                    cmd.Parameters.AddWithValue("@Company_Logo", item.CompanyLogo);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }
        public IList<CompanyProfilePoco> GetAll(params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SELECT [Id]
                                          ,[Registration_Date]
                                          ,[Company_Website]
                                          ,[Contact_Phone]
                                          ,[Contact_Name]
                                          ,[Company_Logo]
                                          ,[Time_Stamp]
                                      FROM [dbo].[Company_Profiles]"
                };
                var list = new List<CompanyProfilePoco>();
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    list.Add(new CompanyProfilePoco
                    {
                        Id = (Guid)reader["Id"],
                        RegistrationDate = Convert.ToDateTime(reader["Registration_Date"]),
                        CompanyWebsite = reader["Company_Website"].ToString(),
                        ContactPhone = reader["Contact_Phone"].ToString(),
                        ContactName = reader["Contact_Name"].ToString(),
                        CompanyLogo = Encoding.ASCII.GetBytes(reader["Company_Logo"].ToString()),
                        TimeStamp = Encoding.ASCII.GetBytes(reader["Time_Stamp"].ToString())
                    });
                }
                conn.Close();
                return list?.ToList();

            }
        }
        public IList<CompanyProfilePoco> GetList(Func<CompanyProfilePoco, bool> where, params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            CompanyProfilePoco[] poco = GetAll().ToArray();
            return poco.Where(where).ToList();
        }
        public CompanyProfilePoco GetSingle(Func<CompanyProfilePoco, bool> where, params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            CompanyProfilePoco[] poco = GetAll().ToArray();
            return poco.Where(where).FirstOrDefault();
        }
        public void Remove(params CompanyProfilePoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Company_Profiles]
                                        WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }
        public void Update(params CompanyProfilePoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Company_Profiles]
                                                   SET 
                                                       [Registration_Date] = @Registration_Date
                                                      ,[Company_Website] = @Company_Website
                                                      ,[Contact_Phone] = @Contact_Phone
                                                      ,[Contact_Name] = @Contact_Name
                                                      ,[Company_Logo] = @Company_Logo
                                                 WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Registration_Date", item.RegistrationDate);
                    cmd.Parameters.AddWithValue("@Company_Website", item.CompanyWebsite);
                    cmd.Parameters.AddWithValue("@Contact_Phone", item.ContactPhone);
                    cmd.Parameters.AddWithValue("@Contact_Name", item.ContactName);
                    cmd.Parameters.AddWithValue("@Company_Logo", item.CompanyLogo);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }
        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
