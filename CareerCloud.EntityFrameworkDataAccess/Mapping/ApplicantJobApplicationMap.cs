using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess.Mapping
{
  public  class ApplicantJobApplicationMap: EntityTypeConfiguration<ApplicantJobApplicationPoco>
    {
        public ApplicantJobApplicationMap()
        {
            //Relation
               HasRequired(t => t.ApplicantProfile)
               .WithMany(t => t.ApplicantJobApplications)
               .HasForeignKey(t => t.Applicant);
        }
    }
}
