using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
   public class CompanyDescriptionPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid Company { get; set; }

        [Required]
        [Column("LanguageID")]
        public string LanguageId { get; set; }

        [StringLength(50)]
        [Required]
        [Column("Company_Name")]
        public string CompanyName { get; set; }
        
        [StringLength(1000)]
        [Required]
        [Column("Company_Description")]
        public string CompanyDescription { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(name: "Time_Stamp", TypeName = "timestamp")]
        public byte[] TimeStamp { get; set; }
        public virtual CompanyProfilePoco CompanyProfile { get; set; }
   
    }
}
