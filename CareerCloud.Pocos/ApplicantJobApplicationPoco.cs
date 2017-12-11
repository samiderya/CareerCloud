using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
   public class ApplicantJobApplicationPoco : IPoco
    {
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public Guid Job { get; set; }
        public DateTime ApplicationDate { get; set; }
        public byte TimeStamp { get; set; }
    }
}
