using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess.Mapping
{
   public class CompanyJobMap: EntityTypeConfiguration<CompanyJobPoco>
    {
        public CompanyJobMap()
        {

                 HasRequired(t => t.CompanyProfile)
                .WithMany(t => t.CompanyJobs)
                .HasForeignKey(d => d.Company);
        }
    }
}
