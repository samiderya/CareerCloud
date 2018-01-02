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
    public class SecurityLoginRepository :BaseClass,IDataRepository<SecurityLoginPoco>
    {
        public void Add(params SecurityLoginPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (SecurityLoginPoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Security_Logins]
                                                           ([Id]
                                                           ,[Login]
                                                           ,[Password]
                                                           ,[Created_Date]
                                                           ,[Password_Update_Date]
                                                           ,[Agreement_Accepted_Date]
                                                           ,[Is_Locked]
                                                           ,[Is_Inactive]
                                                           ,[Email_Address]
                                                           ,[Phone_Number]
                                                           ,[Full_Name]
                                                           ,[Force_Change_Password]
                                                           ,[Prefferred_Language])
                                                     VALUES
                                                           (@Id
                                                           ,@Login
                                                           ,@Password
                                                           ,@Created_Date
                                                           ,@Password_Update_Date
                                                           ,@Agreement_Accepted_Date
                                                           ,@Is_Locked
                                                           ,@Is_Inactive
                                                           ,@Email_Address
                                                           ,@Phone_Number
                                                           ,@Full_Name
                                                           ,@Force_Change_Password
                                                           ,@Prefferred_Language)";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Login", item.Login);
                    cmd.Parameters.AddWithValue("@Password", item.Password);
                    cmd.Parameters.AddWithValue("@Created_Date", item.Created);
                    cmd.Parameters.AddWithValue("@Password_Update_Date", item.PasswordUpdate);
                    cmd.Parameters.AddWithValue("@Agreement_Accepted_Date", item.AgreementAccepted);
                    cmd.Parameters.AddWithValue("@Is_Locked", item.IsLocked);
                    cmd.Parameters.AddWithValue("@Is_Inactive", item.IsInactive);
                    cmd.Parameters.AddWithValue("@Email_Address", item.EmailAddress);
                    cmd.Parameters.AddWithValue("@Phone_Number", item.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Full_Name", item.FullName);
                    cmd.Parameters.AddWithValue("@Force_Change_Password", item.ForceChangePassword);
                    cmd.Parameters.AddWithValue("@Prefferred_Language", item.PrefferredLanguage);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }


            }
        }
        public IList<SecurityLoginPoco> GetAll(params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SELECT [Id]
                                          ,[Login]
                                          ,[Password]
                                          ,[Created_Date]
                                          ,[Password_Update_Date]
                                          ,[Agreement_Accepted_Date]
                                          ,[Is_Locked]
                                          ,[Is_Inactive]
                                          ,[Email_Address]
                                          ,[Phone_Number]
                                          ,[Full_Name]
                                          ,[Force_Change_Password]
                                          ,[Prefferred_Language]
                                          ,[Time_Stamp]
                                      FROM [dbo].[Security_Logins]"
                };
                var list = new List<SecurityLoginPoco>();
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SecurityLoginPoco
                    {
                        Id = (Guid)reader["Id"],
                        Login = reader["Login"].ToString(),
                        Password = reader["Password"].ToString(),
                        Created =Convert.ToDateTime(reader["Created_Date"]),
                        PasswordUpdate =Convert.IsDBNull(reader["Password_Update_Date"])?DateTime.MinValue:Convert.ToDateTime(reader["Password_Update_Date"]),
                        AgreementAccepted =Convert.IsDBNull(reader["Agreement_Accepted_Date"])?DateTime.MinValue: Convert.ToDateTime(reader["Agreement_Accepted_Date"]),
                        IsLocked =(bool) reader["Is_Locked"],
                        IsInactive =(bool)reader["Is_Inactive"],
                        EmailAddress = reader["Email_Address"].ToString(),
                        PhoneNumber = reader["Phone_Number"].ToString(),
                        FullName = reader["Full_Name"].ToString(),
                        ForceChangePassword =(bool)reader["Force_Change_Password"],
                        PrefferredLanguage = reader["Prefferred_Language"].ToString(),
                        TimeStamp = Encoding.ASCII.GetBytes(reader["Time_Stamp"].ToString())
                    });
                }
                conn.Close();
                return list?.ToList();

            }
        }
        public IList<SecurityLoginPoco> GetList(Func<SecurityLoginPoco, bool> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            SecurityLoginPoco[] poco = GetAll().ToArray();
            return poco.Where(where).ToList();
        }
        public SecurityLoginPoco GetSingle(Func<SecurityLoginPoco, bool> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            SecurityLoginPoco[] poco = GetAll().ToArray();
            return poco.Where(where).FirstOrDefault();
        }
        public void Remove(params SecurityLoginPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Security_Logins]
                                                    WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public void Update(params SecurityLoginPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Security_Logins]
                                                   SET 
                                                       [Login] = @Login
                                                      ,[Password] = @Password
                                                      ,[Created_Date] = @Created_Date
                                                      ,[Password_Update_Date] = @Password_Update_Date
                                                      ,[Agreement_Accepted_Date] = @Agreement_Accepted_Date
                                                      ,[Is_Locked] = @Is_Locked
                                                      ,[Is_Inactive] = @Is_Inactive
                                                      ,[Email_Address] = @Email_Address
                                                      ,[Phone_Number] = @Phone_Number
                                                      ,[Full_Name] = @Full_Name
                                                      ,[Force_Change_Password] = @Force_Change_Password
                                                      ,[Prefferred_Language] = @Prefferred_Language
                                                 WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Login", item.Login);
                    cmd.Parameters.AddWithValue("@Password", item.Password);
                    cmd.Parameters.AddWithValue("@Created_Date", item.Created);
                    cmd.Parameters.AddWithValue("@Password_Update_Date", item.PasswordUpdate);
                    cmd.Parameters.AddWithValue("@Agreement_Accepted_Date", item.AgreementAccepted);
                    cmd.Parameters.AddWithValue("@Is_Locked", item.IsLocked);
                    cmd.Parameters.AddWithValue("@Is_Inactive", item.IsInactive);
                    cmd.Parameters.AddWithValue("@Email_Address", item.EmailAddress);
                    cmd.Parameters.AddWithValue("@Phone_Number", item.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Full_Name", item.FullName);
                    cmd.Parameters.AddWithValue("@Force_Change_Password", item.ForceChangePassword);
                    cmd.Parameters.AddWithValue("@Prefferred_Language", item.PrefferredLanguage);
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
