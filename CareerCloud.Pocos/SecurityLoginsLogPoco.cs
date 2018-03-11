using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Log")]
    public class SecurityLoginsLogPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid Login { get; set; }

        [StringLength(15)]
        [Required]
        [Column("Source_IP")]
        public string SourceIP { get; set; }

        [Required]
        [Column("Logon_Date")]
        public DateTime LogonDate { get; set; }

        [Required]
        [Column("Is_Succesful")]
        public bool IsSuccesful { get; set; }

        public virtual SecurityLoginPoco SecurityLogin { get; set; }
    }
}
