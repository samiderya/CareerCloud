using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
   public class ApplicatSkillPoco : IPoco
    {
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string Skill { get; set; }
        public string SkillLevel { get; set; }
        public byte StartMonth { get; set; }
        public byte StartYear { get; set; }
        public byte EndMonth { get; set; }
        public byte EndYear { get; set; }
        public byte TimeStamp { get; set; }
    }
}
