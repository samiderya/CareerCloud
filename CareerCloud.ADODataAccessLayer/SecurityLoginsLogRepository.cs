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
    public class SecurityLoginsLogRepository :BaseClass,IDataRepository<SecurityLoginsLogPoco>
    {
        public void Add(params SecurityLoginsLogPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (SecurityLoginsLogPoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Security_Logins_Log]
                                                           ([Id]
                                                           ,[Login]
                                                           ,[Source_IP]
                                                           ,[Logon_Date]
                                                           ,[Is_Succesful])
                                                     VALUES
                                                           (@Id
                                                           ,@Login
                                                           ,@Source_IP
                                                           ,@Logon_Date
                                                           ,@Is_Succesful)";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Login", item.Login);
                    cmd.Parameters.AddWithValue("@Source_IP", item.SourceIP);
                    cmd.Parameters.AddWithValue("@Logon_Date", item.LogonDate);
                    cmd.Parameters.AddWithValue("@Is_Succesful", item.IsSuccesful);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }


            }
        }
        public IList<SecurityLoginsLogPoco> GetAll(params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SELECT [Id]
                                          ,[Login]
                                          ,[Source_IP]
                                          ,[Logon_Date]
                                          ,[Is_Succesful]
                                      FROM [dbo].[Security_Logins_Log]"
                };
                var list = new List<SecurityLoginsLogPoco>();
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SecurityLoginsLogPoco
                    {
                        Id =(Guid)reader["Id"],
                        Login =(Guid)reader["Login"],
                        SourceIP= reader["Source_IP"].ToString(),
                        LogonDate=Convert.ToDateTime(reader["Logon_Date"]),
                        IsSuccesful=Convert.ToBoolean(reader["Is_Succesful"])

                    });
                }
                conn.Close();
                return list?.ToList();

            }
        }
        public IList<SecurityLoginsLogPoco> GetList(Func<SecurityLoginsLogPoco, bool> where, params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            SecurityLoginsLogPoco[] poco = GetAll().ToArray();
            return poco.Where(where).ToList();
        }
        public SecurityLoginsLogPoco GetSingle(Func<SecurityLoginsLogPoco, bool> where, params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            SecurityLoginsLogPoco[] poco = GetAll().ToArray();
            return poco.Where(where).FirstOrDefault();
        }
        public void Remove(params SecurityLoginsLogPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Security_Logins_Log]
                                                      WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public void Update(params SecurityLoginsLogPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Security_Logins_Log]
                                                   SET 
                                                       [Login] = @Login
                                                      ,[Source_IP] = @Source_IP
                                                      ,[Logon_Date] = @Logon_Date
                                                      ,[Is_Succesful] = @Is_Succesful
                                                 WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Login", item.Login);
                    cmd.Parameters.AddWithValue("@Source_IP", item.SourceIP);
                    cmd.Parameters.AddWithValue("@Logon_Date", item.LogonDate);
                    cmd.Parameters.AddWithValue("@Is_Succesful", item.IsSuccesful);
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
