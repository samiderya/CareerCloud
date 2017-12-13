using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs_Descriptions")]
   public class ComanyJobDescriptionPoco : IPoco
    {
        public Guid Id { get; set; }
        public Guid Job { get; set; }
        [Column("Job_Name")]
        public string JobName { get; set; }
        [Column("Job_Description")]
        public string JobDescription { get; set; }
        [Column("Time_Stamp")]
        public byte? TimeStamp { get; set; }
    }
}
