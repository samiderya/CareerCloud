using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {


            var res = new SystemLanguageCodePoco()
            {
                LanguageID = "AM",
                Name = "AMHARIC",
                NativeName = "AMHA"

            };


            using (CareerCloudContext context = new CareerCloudContext())
            {
                context.Database.Log = Console.Write;
                EFGenericRepository<SystemLanguageCodePoco> eF = new EFGenericRepository<SystemLanguageCodePoco>();
                eF.Add(res);
            }




        }
    }
}
