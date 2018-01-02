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
    public class ApplicantProfileRepository :BaseClass,IDataRepository<ApplicantProfilePoco>
    {
        public void Add(params ApplicantProfilePoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (ApplicantProfilePoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Applicant_Profiles]
                                                           ([Id]
                                                           ,[Login]
                                                           ,[Current_Salary]
                                                           ,[Current_Rate]
                                                           ,[Currency]
                                                           ,[Country_Code]
                                                           ,[State_Province_Code]
                                                           ,[Street_Address]
                                                           ,[City_Town]
                                                           ,[Zip_Postal_Code])
                                                     VALUES
                                                           (@Id
                                                           ,@Login
                                                           ,@Current_Salary
                                                           ,@Current_Rate
                                                           ,@Currency
                                                           ,@Country_Code
                                                           ,@State_Province_Code
                                                           ,@Street_Address
                                                           ,@City_Town
                                                           ,@Zip_Postal_Code)";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Login", item.Login);
                    cmd.Parameters.AddWithValue("@Current_Salary", item.CurrentSalary);
                    cmd.Parameters.AddWithValue("@Current_Rate", item.CurrentRate);
                    cmd.Parameters.AddWithValue("@Currency", item.Currency);
                    cmd.Parameters.AddWithValue("@Country_Code", item.Country);
                    cmd.Parameters.AddWithValue("@State_Province_Code", item.Province);
                    cmd.Parameters.AddWithValue("@Street_Address", item.Street);
                    cmd.Parameters.AddWithValue("@City_Town", item.City);
                    cmd.Parameters.AddWithValue("@Zip_Postal_Code", item.PostalCode);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }

       
        public IList<ApplicantProfilePoco> GetAll(params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SELECT [Id]
                                          ,[Login]
                                          ,[Current_Salary]
                                          ,[Current_Rate]
                                          ,[Currency]
                                          ,[Country_Code]
                                          ,[State_Province_Code]
                                          ,[Street_Address]
                                          ,[City_Town]
                                          ,[Zip_Postal_Code]
                                          ,[Time_Stamp]
                                      FROM [dbo].[Applicant_Profiles]"
                };
                var list = new List<ApplicantProfilePoco>();
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    list.Add(new ApplicantProfilePoco
                    {
                        Id = (Guid)reader["Id"],
                        Login = (Guid)reader["Login"],
                        CurrentSalary = reader["Current_Salary"]!=null?Convert.ToDecimal(reader["Current_Salary"].ToString()):0,
                        CurrentRate = reader["Current_Rate"]!=null?Convert.ToDecimal(reader["Current_Rate"].ToString()):0,
                        Currency = reader["Currency"].ToString(),
                        Country = reader["Country_Code"].ToString(),
                        Province = reader["State_Province_Code"].ToString(),
                        Street = reader["Street_Address"].ToString(),
                        City = reader["City_Town"].ToString(),
                        PostalCode = reader["Zip_Postal_Code"].ToString(),
                        TimeStamp = Encoding.ASCII.GetBytes(reader["Time_Stamp"].ToString())
                    });
                }
                conn.Close();
                return list?.ToList();

            }
        }

        public IList<ApplicantProfilePoco> GetList(Func<ApplicantProfilePoco, bool> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            ApplicantProfilePoco[] poco = GetAll().ToArray();
            return poco.Where(where).ToList();
        }

        public ApplicantProfilePoco GetSingle(Func<ApplicantProfilePoco, bool> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            ApplicantProfilePoco[] poco = GetAll().ToArray();
            return poco.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantProfilePoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Applicant_Profiles]
                                        WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }

        public void Update(params ApplicantProfilePoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Applicant_Profiles]
                                                   SET 
                                                       [Login] = @Login
                                                      ,[Current_Salary] =@Current_Salary
                                                      ,[Current_Rate] = @Current_Rate
                                                      ,[Currency] = @Currency
                                                      ,[Country_Code] = @Country_Code
                                                      ,[State_Province_Code] = @State_Province_Code
                                                      ,[Street_Address] = @Street_Address
                                                      ,[City_Town] = @City_Town
                                                      ,[Zip_Postal_Code] = @Zip_Postal_Code
                                                 WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Login", item.Login);
                    cmd.Parameters.AddWithValue("@Current_Salary", item.CurrentSalary);
                    cmd.Parameters.AddWithValue("@Current_Rate", item.CurrentRate);
                    cmd.Parameters.AddWithValue("@Currency", item.Currency);
                    cmd.Parameters.AddWithValue("@Country_Code", item.Country);
                    cmd.Parameters.AddWithValue("@State_Province_Code", item.Province);
                    cmd.Parameters.AddWithValue("@Street_Address", item.Street);
                    cmd.Parameters.AddWithValue("@City_Town", item.City);
                    cmd.Parameters.AddWithValue("@Zip_Postal_Code", item.PostalCode);
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
