using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Educations")]
    public class ApplicantEducationPoco : IPoco
    {
        [Key]
        public System.Guid Id { get; set; }

        [Required]
        public Guid Applicant { get; set; }

        [Required(ErrorMessage ="*")]
        [StringLength(100,ErrorMessage ="Cannot be more than 100 character")]
        public string Major { get; set; }

        [StringLength(100, ErrorMessage = "Cannot be more than 100 character")]
        [Column("Certificate_Diploma")]
        public string CertificateDiploma { get; set; }

        [Column("Start_Date")]
        public DateTime? StartDate { get; set; }

        [Column(name:"Completion_Date",TypeName = "DateTime")]
        public DateTime? CompletionDate { get; set; }

        [Column("Completion_Percent")]
        public byte? CompletionPercent { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(name:"Time_Stamp",TypeName ="timestamp")]
        public byte[] TimeStamp { get; set; }


    }
}
