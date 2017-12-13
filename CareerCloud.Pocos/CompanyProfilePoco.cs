using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]
    public class CompanyProfilePoco : IPoco
    {
        public Guid Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string CompanyWebsite { get; set; }
        public string ContactPhone { get; set; }
        public string ContactName { get; set; }
        public string Company_Logo { get; set; }
        public byte TimeStamp { get; set; }
    }
}
