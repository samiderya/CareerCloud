using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess.Mapping
{
   public class CompanyDescriptionMap : EntityTypeConfiguration<CompanyDescriptionPoco>
    {
        public CompanyDescriptionMap()
        {
            HasRequired(t => t.CompanyProfile)
                .WithMany(t => t.CompanyDescriptions)
                .HasForeignKey(t => t.Company);
        }
    }
}
