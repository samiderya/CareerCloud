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
    public class SystemLanguageCodeRepository :BaseClass,IDataRepository<SystemLanguageCodePoco>
    {
       

        public void Add(params SystemLanguageCodePoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (SystemLanguageCodePoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[System_Language_Codes]
                                                           ([LanguageID]
                                                           ,[Name]
                                                           ,[Native_Name])
                                                     VALUES
                                                           (@LanguageID
                                                           ,@Name
                                                           ,@Native_Name)";
                    cmd.Parameters.AddWithValue("@LanguageID", item.LanguageID);
                    cmd.Parameters.AddWithValue("@Name", item.Name);
                    cmd.Parameters.AddWithValue("@Native_Name", item.NativeName);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }
        public IList<SystemLanguageCodePoco> GetAll(params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SELECT [LanguageID]
                                              ,[Name]
                                              ,[Native_Name]
                                          FROM [dbo].[System_Language_Codes]"
                };
                var list = new List<SystemLanguageCodePoco>();
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SystemLanguageCodePoco
                    {
                        LanguageID = reader["LanguageID"].ToString(),
                        Name = reader["Name"].ToString(),
                        NativeName = reader["Native_Name"].ToString()
                    });
                }
                conn.Close();
                return list?.ToList();

            }
        }
        public IList<SystemLanguageCodePoco> GetList(Func<SystemLanguageCodePoco, bool> where, params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            SystemLanguageCodePoco[] poco = GetAll().ToArray();
            return poco.Where(where).ToList();
        }
        public SystemLanguageCodePoco GetSingle(Func<SystemLanguageCodePoco, bool> where, params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            SystemLanguageCodePoco[] poco = GetAll().ToArray();
            return poco.Where(where).FirstOrDefault();
        }
        public void Remove(params SystemLanguageCodePoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[System_Language_Codes]
                                                      WHERE LanguageID=@LanguageID";
                    cmd.Parameters.AddWithValue("@LanguageID", item.LanguageID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public void Update(params SystemLanguageCodePoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[System_Language_Codes]
                                                   SET 
                                                       [Name] = @Name
                                                      ,[Native_Name] = @Native_Name
                                                 WHERE [LanguageID] = @LanguageID";

                    cmd.Parameters.AddWithValue("@LanguageID", item.LanguageID);
                    cmd.Parameters.AddWithValue("@Native_Name", item.NativeName);
                    cmd.Parameters.AddWithValue("@Name", item.Name);
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
