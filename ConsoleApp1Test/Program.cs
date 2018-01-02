using CareerCloud.ADODataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new ApplicantEducationRepository();

            string strtime = DateTime.Now.ToUniversalTime().ToString();
            byte[] time = System.Text.Encoding.ASCII.GetBytes(strtime);
            var lst = new ApplicantEducationPoco()
            {
                Id = new Guid("2F206645-3F76-480D-82C6-75DCDB799290"),
                Applicant=new Guid("22525A95-084D-73CA-860C-C1C11E4FEF4C"),
                Major="sami",
                CertificateDiploma= "Bachler",
                CompletionDate=DateTime.Now,
                CompletionPercent=100,
                StartDate=DateTime.Now,
                TimeStamp= time

            };

            //**Update
            repository.Update(lst);

            //**Remove

            repository.Remove(lst);

            //**GetSingle
            var getSingle = repository.GetSingle(a => a.CompletionPercent == 100);

            //***GetAll
            // var list = repository.GetAll();


            //***Add
            
            //var data = new ApplicantEducationPoco()
            //{
            //    Id= Guid.NewGuid(),
            //    Applicant = new Guid("22525A95-084D-73CA-860C-C1C11E4FEF4C"),
            //    Major = "Computer Programming",
            //    CertificateDiploma = "000000000",
            //    CompletionDate = DateTime.Now,
            //    StartDate = DateTime.Now,
            //    CompletionPercent = 100,
            //    TimeStamp = time
            //};
            //repository.Add(data);
        }
    }
}
