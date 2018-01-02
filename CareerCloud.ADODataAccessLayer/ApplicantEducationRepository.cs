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
    public class ApplicantEducationRepository : BaseClass,IDataRepository<ApplicantEducationPoco>
    {
        public void Add(params ApplicantEducationPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (ApplicantEducationPoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO   [dbo].[Applicant_Educations]
                                                        (
                                                        [Id],
                                                        [Applicant],
                                                        [Major],
                                                        [Certificate_Diploma],
                                                        [Start_Date],
                                                        [Completion_Date],
                                                        [Completion_Percent]
                                                        )
                                            VALUES
                                                       
                                                       (@Id,
                                                        @Applicant,
                                                        @Major,
                                                        @Certificate_Diploma,
                                                        @Start_Date,
                                                        @Completion_Date,
                                                        @Completion_Percent
                                                        )";
                    cmd.Parameters.AddWithValue("@Id",item.Id);
                    cmd.Parameters.AddWithValue("@Applicant", item.Applicant);
                    cmd.Parameters.AddWithValue("@Major", item.Major);
                    cmd.Parameters.AddWithValue("@Certificate_Diploma", item.CertificateDiploma);
                    cmd.Parameters.AddWithValue("@Start_Date", item.StartDate);
                    cmd.Parameters.AddWithValue("@Completion_Date", item.CompletionDate);
                    cmd.Parameters.AddWithValue("@Completion_Percent", item.CompletionPercent);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                   
                }


            }
        }

        public IList<ApplicantEducationPoco> GetAll(params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            using (var conn=new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SELECT [Id]
                                          ,[Applicant]
                                          ,[Major]
                                          ,[Certificate_Diploma]
                                          ,[Start_Date]
                                          ,[Completion_Date]
                                          ,[Completion_Percent]
                                          ,[Time_Stamp]
                                      FROM [dbo].[Applicant_Educations]"
                };
                var list = new List<ApplicantEducationPoco>();
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  
                    list.Add(new ApplicantEducationPoco
                    {
                        Id=(Guid)reader["Id"],
                        Applicant=(Guid)reader["Applicant"],
                        CertificateDiploma=reader["Certificate_Diploma"].ToString(),
                        CompletionDate=Convert.ToDateTime(reader["Completion_Date"]),
                        CompletionPercent=Convert.ToByte(reader["Completion_Percent"]),
                        Major=reader["Major"].ToString(),
                        StartDate=Convert.ToDateTime(reader["Start_Date"]),
                        TimeStamp= Encoding.ASCII.GetBytes(reader["Time_Stamp"].ToString())
                    });
                }
                conn.Close();
                return list?.ToList();

            }
        }

        public IList<ApplicantEducationPoco> GetList(Func<ApplicantEducationPoco, bool> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            ApplicantEducationPoco[] poco = GetAll().ToArray();
            return poco.Where(where).ToList();
        }

        public ApplicantEducationPoco GetSingle(Func<ApplicantEducationPoco, bool> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            ApplicantEducationPoco[] poco = GetAll().ToArray();
            return poco.Where(where).FirstOrDefault();
        }

        //We can pass only Id for delete instade of all items
        public void Remove(params ApplicantEducationPoco[] items)
        {
            using (var conn=new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Applicant_Educations]
                                        WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }

        public void Update(params ApplicantEducationPoco[] items)
        {
            using (var conn=new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Applicant_Educations]
                                   SET 
                                       [Applicant] = @Applicant
                                      ,[Major] = @Major
                                      ,[Certificate_Diploma] =@Certificate_Diploma
                                      ,[Start_Date] =@Start_Date
                                      ,[Completion_Date] = @Completion_Date
                                      ,[Completion_Percent] = @Completion_Percent
                                 WHERE [Id]=@Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Applicant", item.Applicant);
                    cmd.Parameters.AddWithValue("@Major", item.Major);
                    cmd.Parameters.AddWithValue("@Certificate_Diploma", item.CertificateDiploma);
                    cmd.Parameters.AddWithValue("@Start_Date", item.StartDate);
                    cmd.Parameters.AddWithValue("@Completion_Date", item.CompletionDate);
                    cmd.Parameters.AddWithValue("@Completion_Percent", item.CompletionPercent);
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
