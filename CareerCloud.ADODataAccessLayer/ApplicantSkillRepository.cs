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
    public class ApplicantSkillRepository :BaseClass,IDataRepository<ApplicantSkillPoco>
    {
        public void Add(params ApplicantSkillPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (ApplicantSkillPoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Applicant_Skills]
                                                       ([Id]
                                                       ,[Applicant]
                                                       ,[Skill]
                                                       ,[Skill_Level]
                                                       ,[Start_Month]
                                                       ,[Start_Year]
                                                       ,[End_Month]
                                                       ,[End_Year])
                                                 VALUES
                                                       (@Id
                                                       ,@Applicant
                                                       ,@Skill
                                                       ,@Skill_Level
                                                       ,@Start_Month
                                                       ,@Start_Year
                                                       ,@End_Month
                                                       ,@End_Year)";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Applicant", item.Applicant);
                    cmd.Parameters.AddWithValue("@Skill", item.Skill);
                    cmd.Parameters.AddWithValue("@Skill_Level", item.SkillLevel);
                    cmd.Parameters.AddWithValue("@Start_Month", item.StartMonth);
                    cmd.Parameters.AddWithValue("@Start_Year", item.StartYear);
                    cmd.Parameters.AddWithValue("@End_Month", item.EndMonth);
                    cmd.Parameters.AddWithValue("@End_Year", item.EndYear);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }
        public IList<ApplicantSkillPoco> GetAll(params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SELECT [Id]
                                          ,[Applicant]
                                          ,[Skill]
                                          ,[Skill_Level]
                                          ,[Start_Month]
                                          ,[Start_Year]
                                          ,[End_Month]
                                          ,[End_Year]
                                          ,[Time_Stamp]
                                      FROM [dbo].[Applicant_Skills]"
                };
                var list = new List<ApplicantSkillPoco>();
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ApplicantSkillPoco
                    {
                        Id = (Guid)reader["Id"],
                        Applicant = (Guid)reader["Applicant"],
                        Skill = reader["Skill"].ToString(),
                        SkillLevel = reader["Skill_Level"].ToString(),
                        StartMonth = Convert.ToByte(reader["Start_Month"]),
                        StartYear = Convert.ToInt32(reader["Start_Year"].ToString()),
                        EndMonth = Convert.ToByte(reader["End_Month"]),
                        EndYear = Convert.ToInt32(reader["End_Year"]),
                        TimeStamp = Encoding.ASCII.GetBytes(reader["Time_Stamp"].ToString())
                    });
                }
                conn.Close();
                return list?.ToList();

            }
        }
        public IList<ApplicantSkillPoco> GetList(Func<ApplicantSkillPoco, bool> where, params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            ApplicantSkillPoco[] poco = GetAll().ToArray();
            return poco.Where(where).ToList();
        }
        public ApplicantSkillPoco GetSingle(Func<ApplicantSkillPoco, bool> where, params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            ApplicantSkillPoco[] poco = GetAll().ToArray();
            return poco.Where(where).FirstOrDefault();
        }
        public void Remove(params ApplicantSkillPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Applicant_Skills]
                                        WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }
        public void Update(params ApplicantSkillPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Applicant_Skills]
                                                   SET 
                                                       [Applicant] = @Applicant
                                                      ,[Skill] = @Skill
                                                      ,[Skill_Level] = @Skill_Level
                                                      ,[Start_Month] = @Start_Month
                                                      ,[Start_Year] = @Start_Year
                                                      ,[End_Month] = @End_Month
                                                      ,[End_Year] = @End_Year
                                                 WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Applicant", item.Applicant);
                    cmd.Parameters.AddWithValue("@Skill", item.Skill);
                    cmd.Parameters.AddWithValue("@Skill_Level", item.SkillLevel);
                    cmd.Parameters.AddWithValue("@Start_Month", item.StartMonth);
                    cmd.Parameters.AddWithValue("@Start_Year", item.StartYear);
                    cmd.Parameters.AddWithValue("@End_Month", item.EndMonth);
                    cmd.Parameters.AddWithValue("@End_Year", item.EndYear);
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
