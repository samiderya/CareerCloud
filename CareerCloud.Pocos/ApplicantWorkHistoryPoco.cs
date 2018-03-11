using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Work_History")]
   public class ApplicantWorkHistoryPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage ="*")]
        [Column("Company_Name")]
        public string CompanyName { get; set; }
        [Required]
        [Column("Country_Code")]
        public string CountryCode { get; set; }

        [StringLength(50)]
        [Required]
        public string Location { get; set; }

        [StringLength(50)]
        [Required]
        [Column("Job_Title")]
        public string JobTitle { get; set; }

        [StringLength(500)]
        [Required]
        [Column("Job_Description")]
        public string JobDescription { get; set; }
        [Required]
        [Column("Start_Month")]
        public short StartMonth { get; set; }
        [Required]
        [Column("End_Month")]
        public short EndMonth { get; set; }
        [Required]
        [Column("Start_Year")]
        public int StartYear { get; set; }
        [Required]
        [Column("End_Year")]
        public int EndYear { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(name: "Time_Stamp", TypeName = "timestamp")]
        public byte[] TimeStamp { get; set; }
        public virtual ApplicantProfilePoco ApplicantProfile { get; set; }
    
    }
}
