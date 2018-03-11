using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Locations")]
    public class CompanyLocationPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid Company { get; set; }

        [Required]
        [Column("Country_Code")]
        public string CountryCode { get; set; }

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

        //company has mony location
        public virtual CompanyProfilePoco CompanyProfile { get; set; }
    }
}
