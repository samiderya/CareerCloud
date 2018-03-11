using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess.Mapping
{
   public class ApplicantWorkHistoryMap: EntityTypeConfiguration<ApplicantWorkHistoryPoco>
    {
        public ApplicantWorkHistoryMap()
        {
            HasRequired(t => t.ApplicantProfile)
            .WithMany(t => t.ApplicantWorkHistories)
            .HasForeignKey(t => t.Applicant);
            //    .WithRequiredDependent(t=>t.)
        }
    }
}
