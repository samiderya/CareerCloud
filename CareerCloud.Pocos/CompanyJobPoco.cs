using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs")]
    public class CompanyJobPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid Company { get; set; }

        [Required]
        [Column("Profile_Created")]
        public DateTime ProfileCreated { get; set; }
        [Required]
        [Column("Is_Inactive")]
        public bool IsInactive { get; set; }

        [Required]
        [Column("Is_Company_Hidden")]
        public bool IsCompanyHidden { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(name: "Time_Stamp", TypeName = "timestamp")]
        public Byte[] TimeStamp { get; set; }

        public virtual ICollection<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public virtual CompanyProfilePoco CompanyProfile { get; set; }
        
    }
}
