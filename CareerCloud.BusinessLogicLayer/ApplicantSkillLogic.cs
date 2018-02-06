using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantSkillLogic : BaseLogic<ApplicantSkillPoco>
    {
        public ApplicantSkillLogic(IDataRepository<ApplicantSkillPoco> repository) : base(repository)
        {
        }

        public override void Add(ApplicantSkillPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override ApplicantSkillPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<ApplicantSkillPoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(ApplicantSkillPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(ApplicantSkillPoco[] pocos)
        {
            //ApplicantSkillLogic StartMonth  Cannot be greater than 12   101
            //ApplicantSkillLogic EndMonth    Cannot be greater than 12   102
            //ApplicantSkillLogic StartYear   Cannot be less then 1900    103
            //ApplicantSkillLogic EndYear Cannot be less then StartYear   104

            List<ValidationException> exception = new List<ValidationException>();
            foreach (var poco in pocos)
            {
                if(poco.StartMonth>12)
                {
                    exception.Add(new ValidationException(101, "ApplicantSkillLogic StartMonth  Cannot be greater than 12"));
                }
                else if(poco.EndMonth>12)
                {
                    exception.Add(new ValidationException(102, "ApplicantSkillLogic EndMonth    Cannot be greater than 12"));
                }
                else if(poco.StartYear<1900)
                {
                    exception.Add(new ValidationException(103, "ApplicantSkillLogic StartYear   Cannot be less then 1900"));
                }
                else if(poco.EndYear<poco.StartYear)
                {
                    exception.Add(new ValidationException(104, "ApplicantSkillLogic EndYear Cannot be less then StartYear"));
                }
            }
            if(exception.Count>0)
            {
                throw new AggregateException(exception);
            }

           
        }
    }
}
