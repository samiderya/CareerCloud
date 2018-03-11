using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess.Mapping
{
   public class SecurityLoginsLogMap : EntityTypeConfiguration<SecurityLoginsLogPoco>
    {
        public SecurityLoginsLogMap()
        {
            HasRequired(t => t.SecurityLogin)
                .WithMany(t => t.SecurityLoginsLogs)
                .HasForeignKey(t => t.Login);
        }
    }
}
