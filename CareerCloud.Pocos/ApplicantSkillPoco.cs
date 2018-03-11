using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Skills")]
   public class ApplicantSkillPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid Applicant { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="*")]
        public string Skill { get; set; }

        [StringLength(10)]
        [Required]
        [Column("Skill_Level")]
        public string SkillLevel { get; set; }

        [Required]
        [Column("Start_Month")]
        public byte StartMonth { get; set; }
        [Required]
        [Column("Start_Year")]
        public int StartYear { get; set; }
        [Required]
        [Column("End_Month")]
        public byte EndMonth { get; set; }
        [Required]
        [Column("End_Year")]
        public int EndYear { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(name: "Time_Stamp", TypeName = "timestamp")]
        public byte[] TimeStamp { get; set; }

        public virtual ApplicantProfilePoco ApplicantProfile  { get; set; }
    }
}
