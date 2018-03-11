using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Roles")]
    public class SecurityLoginsRolePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid Login { get; set; }

        [Required]
        public Guid Role { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(name: "Time_Stamp", TypeName = "timestamp")]
        public byte[] TimeStamp { get; set; }

        public virtual SecurityRolePoco SecurityRole { get; set; }
    }
}
