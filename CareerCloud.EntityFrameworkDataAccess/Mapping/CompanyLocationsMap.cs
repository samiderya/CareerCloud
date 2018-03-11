using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess.Mapping
{
   public class CompanyLocationsMap: EntityTypeConfiguration<CompanyLocationPoco>
    {
        public CompanyLocationsMap()
        {
            //Relation
            HasRequired(t => t.CompanyProfile)
                 .WithMany(t => t.CompanyLocations)
                 .HasForeignKey(t => t.Company);
        }
    }
}
