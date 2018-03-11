using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Skills")]
    public class CompanyJobSkillPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid Job { get; set; }

        [StringLength(100)]
        [Required]
        public string Skill { get; set; }

        [StringLength(10)]
        [Required]
        [Column("Skill_Level")]
        public string SkillLevel { get; set; }
      
        [Required]
        public int Importance { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(name: "Time_Stamp", TypeName = "timestamp")]
        public byte[] TimeStamp { get; set; }
   
        public virtual CompanyJobPoco CompanyJobs { get; set; }
    }
}
