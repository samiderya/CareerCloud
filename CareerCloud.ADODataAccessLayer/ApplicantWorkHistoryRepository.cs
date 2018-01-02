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
    public class ApplicantWorkHistoryRepository :BaseClass,IDataRepository<ApplicantWorkHistoryPoco>
    {
        public void Add(params ApplicantWorkHistoryPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (ApplicantWorkHistoryPoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Applicant_Work_History]
                                                                   ([Id]
                                                                   ,[Applicant]
                                                                   ,[Company_Name]
                                                                   ,[Country_Code]
                                                                   ,[Location]
                                                                   ,[Job_Title]
                                                                   ,[Job_Description]
                                                                   ,[Start_Month]
                                                                   ,[Start_Year]
                                                                   ,[End_Month]
                                                                   ,[End_Year])
                                                             VALUES
                                                                   (@Id
                                                                   ,@Applicant
                                                                   ,@Company_Name
                                                                   ,@Country_Code
                                                                   ,@Location
                                                                   ,@Job_Title
                                                                   ,@Job_Description
                                                                   ,@Start_Month
                                                                   ,@Start_Year
                                                                   ,@End_Month
                                                                   ,@End_Year)";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Applicant", item.Applicant);
                    cmd.Parameters.AddWithValue("@Company_Name", item.CompanyName);
                    cmd.Parameters.AddWithValue("@Country_Code", item.CountryCode);
                    cmd.Parameters.AddWithValue("@Location", item.Location);
                    cmd.Parameters.AddWithValue("@Job_Title", item.JobTitle);
                    cmd.Parameters.AddWithValue("@Job_Description", item.JobDescription);
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

        public IList<ApplicantWorkHistoryPoco> GetAll(params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"SELECT [Id]
                                          ,[Applicant]
                                          ,[Company_Name]
                                          ,[Country_Code]
                                          ,[Location]
                                          ,[Job_Title]
                                          ,[Job_Description]
                                          ,[Start_Month]
                                          ,[Start_Year]
                                          ,[End_Month]
                                          ,[End_Year]
                                          ,[Time_Stamp]
                                      FROM [dbo].[Applicant_Work_History]"
                };
                var list = new List<ApplicantWorkHistoryPoco>();
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    list.Add(new ApplicantWorkHistoryPoco
                    {
                        Id = (Guid)reader["Id"],
                        Applicant = (Guid)reader["Applicant"],
                        CompanyName = reader["Company_Name"].ToString(),
                        CountryCode = reader["Country_Code"].ToString(),
                        Location = reader["Location"].ToString(),
                        JobTitle = reader["Job_Title"].ToString(),
                        JobDescription = reader["Job_Description"].ToString(),
                        StartMonth =(short)reader["Start_Month"],
                        StartYear =(int)reader["Start_Year"],
                        EndMonth =(short)reader["End_Month"],
                        EndYear =(int)reader["End_Year"],
                        TimeStamp = Encoding.ASCII.GetBytes(reader["Time_Stamp"].ToString())
                    });
                }
                conn.Close();
                return list?.ToList();

            }
        }

        public IList<ApplicantWorkHistoryPoco> GetList(Func<ApplicantWorkHistoryPoco, bool> where, params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            ApplicantWorkHistoryPoco[] poco = GetAll().ToArray();
            return poco.Where(where).ToList();
        }

        public ApplicantWorkHistoryPoco GetSingle(Func<ApplicantWorkHistoryPoco, bool> where, params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            ApplicantWorkHistoryPoco[] poco = GetAll().ToArray();
            return poco.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantWorkHistoryPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Applicant_Work_History]
                                        WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }

        public void Update(params ApplicantWorkHistoryPoco[] items)
        {
            using (var conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn
                };
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Applicant_Work_History]
                                                   SET 
                                                       [Applicant] =@Applicant
                                                      ,[Company_Name] =@Company_Name
                                                      ,[Country_Code] =@Country_Code
                                                      ,[Location] =@Location
                                                      ,[Job_Title] =@Job_Title
                                                      ,[Job_Description] =@Job_Description
                                                      ,[Start_Month] =@Start_Month
                                                      ,[Start_Year] =@Start_Year
                                                      ,[End_Month] =@End_Month
                                                      ,[End_Year] =@End_Year
                                                 WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Applicant", item.Applicant);
                    cmd.Parameters.AddWithValue("@Company_Name", item.CompanyName);
                    cmd.Parameters.AddWithValue("@Country_Code", item.CountryCode);
                    cmd.Parameters.AddWithValue("@Location", item.Location);
                    cmd.Parameters.AddWithValue("@Job_Title", item.JobTitle);
                    cmd.Parameters.AddWithValue("@Job_Description", item.JobDescription);
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
