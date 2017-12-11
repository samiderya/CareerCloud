using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
   public class ApplicantProfilePoco : IPoco
    {
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        public decimal? CurrentSalary { get; set; }
        public decimal? CurrentRate { get; set; }
        public string CountryCode { get; set; }
        public string StateProvinceCode { get; set; }
        public string StreetAddress { get; set; }
        public string CityTown { get; set; }
        public string ZipPostalCode { get; set; }
        public byte TimeStamp { get; set; }
    }
}
