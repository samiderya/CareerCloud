using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")]
    public class ApplicantProfilePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid Login { get; set; }

        [DataType("decimal(18,0)")]
        [Column("Current_Salary")]
        public decimal? CurrentSalary { get; set; }

        [DataType("decimal(18,2)")]
        [Column("Current_Rate")]
        public decimal? CurrentRate { get; set; }

        [StringLength(10)]
        [Column("Currency")]
        public string Currency { get; set; }

        [StringLength(10)]
        [Column("Country_Code")]
        public string Country { get; set; }

        [StringLength(10)]
        [Column("State_Province_Code")]
        public string Province { get; set; }

        [StringLength(100)]
        [Column("Street_Address")]
        public string Street { get; set; }

        [StringLength(100)]
        [Column("City_Town")]
        public string City { get; set; }

        [StringLength(20)]
        [Column("Zip_Postal_Code")]
        public string PostalCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(name: "Time_Stamp", TypeName = "timestamp")]
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public virtual ICollection<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }

        

    }
}
