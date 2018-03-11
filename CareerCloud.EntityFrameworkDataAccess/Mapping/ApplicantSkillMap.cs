using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess.Mapping
{
   public class ApplicantSkillMap: EntityTypeConfiguration<ApplicantSkillPoco>
    {
        public ApplicantSkillMap()
        {
            HasRequired(t => t.ApplicantProfile)
                .WithMany(t => t.ApplicantSkills)
                .HasForeignKey(t => t.Applicant);
        }
    }
}
