using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyDescriptionRepository :BaseClass,IDataRepository<CompanyDescriptionPoco>
    {
        public void Add(params CompanyDescriptionPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (CompanyDescriptionPoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Company_Descriptions]
                                                           ([Id]
                                                           ,[Company]
                                                           ,[LanguageID]
                                                           ,[Company_Name]
                                                           ,[Company_Description])
                                                     VALUES
                                                           (@Id
                                                           ,@Company
                                                           ,@LanguageID
                                                           ,@Company_Name
                                                           ,@Company_Description)";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Company", item.Company);
                    cmd.Parameters.AddWithValue("@LanguageID", item.LanguageId);
                    cmd.Parameters.AddWithValue("@Company_Name", item.CompanyName);
                    cmd.Parameters.AddWithValue("@Company_Description", item.CompanyDescription);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }


            }
        }

        public IList<CompanyDescriptionPoco> GetAll(params System.Linq.Expressions.Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SELECT [Id]
                                          ,[Company]
                                          ,[LanguageID]
                                          ,[Company_Name]
                                          ,[Company_Description]
                                          ,[Time_Stamp]
                                      FROM [dbo].[Company_Descriptions]"
                };
                var list = new List<CompanyDescriptionPoco>();
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new CompanyDescriptionPoco
                    {
                        Id = (Guid)reader["Id"],
                        Company = (Guid)reader["Company"],
                        LanguageId = reader["LanguageID"].ToString(),
                        CompanyName = reader["Company_Name"].ToString(),
                        CompanyDescription = reader["Company_Description"].ToString(),
                        TimeStamp = Encoding.ASCII.GetBytes(reader["Time_Stamp"].ToString())
                    });
                }
                conn.Close();
                return list?.ToList();

            }
        }
        public IList<CompanyDescriptionPoco> GetList(Func<CompanyDescriptionPoco, bool> where, params System.Linq.Expressions.Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            CompanyDescriptionPoco[] poco = GetAll().ToArray();
            return poco.Where(where).ToList();
        }
        public CompanyDescriptionPoco GetSingle(Func<CompanyDescriptionPoco, bool> where, params System.Linq.Expressions.Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            CompanyDescriptionPoco[] poco = GetAll().ToArray();
            return poco.Where(where).FirstOrDefault();
        }
        public void Remove(params CompanyDescriptionPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Company_Descriptions]
                                                        WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }
        public void Update(params CompanyDescriptionPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Company_Descriptions]
                                                   SET 
                                                       [Company] = @Company
                                                      ,[LanguageID] = @LanguageID
                                                      ,[Company_Name] = @Company_Name
                                                      ,[Company_Description] = @Company_Description
                                                 WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Company", item.Company);
                    cmd.Parameters.AddWithValue("@LanguageID", item.LanguageId);
                    cmd.Parameters.AddWithValue("@Company_Name", item.CompanyName);
                    cmd.Parameters.AddWithValue("@Company_Description", item.CompanyDescription);
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
