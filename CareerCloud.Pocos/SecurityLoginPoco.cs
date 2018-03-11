using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins")]
    public class SecurityLoginPoco : IPoco
    {
       [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Login { get; set; }

        [StringLength(100)]
        [Required]
        public string Password { get; set; }

        [Required]
        [Column("Created_Date")]
        public DateTime Created { get; set; }


        [Column("Password_Update_Date")]
        public DateTime? PasswordUpdate { get; set; }
        [Column("Agreement_Accepted_Date")]
        public DateTime? AgreementAccepted { get; set; }

        [Required]
        [Column("Is_Locked")]
        public bool IsLocked { get; set; }
        [Required]
        [Column("Is_Inactive")]
        public bool IsInactive { get; set; }

        [StringLength(50)]
        [Required]
        [Column("Email_Address")]
        public string EmailAddress { get; set; }

        [StringLength(20)]
        [Column("Phone_Number")]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        [Column("Full_Name")]
        public string FullName { get; set; }

        [Required]
        [Column("Force_Change_Password")]
        public bool ForceChangePassword { get; set; }

        [StringLength(10)]
        [Column("Prefferred_Language")]
        public string PrefferredLanguage { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(name: "Time_Stamp", TypeName = "timestamp")]
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
    }
}
