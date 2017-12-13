using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Resumes")]
   public class ApplicantResumePoco : IPoco
    {
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string Resume { get; set; }
        [Column("Last_Update")]
        public DateTime LastUpdate { get; set; }

    }
}
