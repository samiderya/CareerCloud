using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs_Descriptions")]
   public class CompanyJobDescriptionPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid Job { get; set; }

        [StringLength(100)]
        [Column("Job_Name")]
        public string JobName { get; set; }

        [StringLength(1000)]
        [Column("Job_Descriptions")]
        public string JobDescriptions { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(name: "Time_Stamp", TypeName = "timestamp")]
        public byte[] TimeStamp { get; set; }

    }
}
