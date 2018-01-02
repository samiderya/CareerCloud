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
    public class CompanyJobSkillRepository :BaseClass,IDataRepository<CompanyJobSkillPoco>
    {
        public void Add(params CompanyJobSkillPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (CompanyJobSkillPoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Company_Job_Skills]
                                                           ([Id]
                                                           ,[Job]
                                                           ,[Skill]
                                                           ,[Skill_Level]
                                                           ,[Importance])
                                                     VALUES
                                                           (@Id
                                                           ,@Job
                                                           ,@Skill
                                                           ,@Skill_Level
                                                           ,@Importance)";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Job", item.Job);
                    cmd.Parameters.AddWithValue("@Skill", item.Skill);
                    cmd.Parameters.AddWithValue("@Skill_Level", item.SkillLevel);
                    cmd.Parameters.AddWithValue("@Importance", item.Importance);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }


            }
        }
        public IList<CompanyJobSkillPoco> GetAll(params System.Linq.Expressions.Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SELECT [Id]
                                          ,[Job]
                                          ,[Skill]
                                          ,[Skill_Level]
                                          ,[Importance]
                                          ,[Time_Stamp]
                                      FROM [dbo].[Company_Job_Skills]"
                };
                var list = new List<CompanyJobSkillPoco>();
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    list.Add(new CompanyJobSkillPoco
                    {
                        Id = (Guid)reader["Id"],
                        Job =(Guid)reader["Job"],
                        Skill = reader["Skill"].ToString(),
                        SkillLevel = reader["Skill_Level"].ToString(),
                        Importance =Convert.ToInt32(reader["Importance"]),
                        TimeStamp = Encoding.ASCII.GetBytes(reader["Time_Stamp"].ToString())
                    });
                }
                conn.Close();
                return list?.ToList();

            }
        }
        public IList<CompanyJobSkillPoco> GetList(Func<CompanyJobSkillPoco, bool> where, params System.Linq.Expressions.Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            CompanyJobSkillPoco[] poco = GetAll().ToArray();
            return poco.Where(where).ToList();
        }
        public CompanyJobSkillPoco GetSingle(Func<CompanyJobSkillPoco, bool> where, params System.Linq.Expressions.Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            CompanyJobSkillPoco[] poco = GetAll().ToArray();
            return poco.Where(where).FirstOrDefault();
        }
        public void Remove(params CompanyJobSkillPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Company_Job_Skills]
                                                     WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public void Update(params CompanyJobSkillPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Company_Job_Skills]
                                               SET 
                                                   [Job] = @Job
                                                  ,[Skill] = @Skill
                                                  ,[Skill_Level] = @Skill_Level
                                                  ,[Importance] = @Importance
                                             WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Job", item.Job);
                    cmd.Parameters.AddWithValue("@Skill", item.Skill);
                    cmd.Parameters.AddWithValue("@Skill_Level", item.SkillLevel);
                    cmd.Parameters.AddWithValue("@Importance", item.Importance);
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
