using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess.Mapping
{
   public class SecurityLoginsRoleMap: EntityTypeConfiguration<SecurityLoginsRolePoco>
    {
        public SecurityLoginsRoleMap()
        {
            HasRequired(t => t.SecurityRole)
                .WithMany(t => t.SecurityLoginsRoles)
                .HasForeignKey(t => t.Role);
        }
    }
}
