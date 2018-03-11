using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess.Mapping
{
   public class CompanyJobSkillMap : EntityTypeConfiguration<CompanyJobSkillPoco>
    {
        public CompanyJobSkillMap()
        {
            HasRequired(t => t.CompanyJobs)
                .WithMany(t => t.CompanyJobSkills)
                .HasForeignKey(t => t.Job);
        }
    }
}
