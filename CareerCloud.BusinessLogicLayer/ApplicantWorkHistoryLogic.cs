using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantWorkHistoryLogic : BaseLogic<ApplicantWorkHistoryPoco>
    {
        public ApplicantWorkHistoryLogic(IDataRepository<ApplicantWorkHistoryPoco> repository) : base(repository)
        {
        }

        public override void Add(ApplicantWorkHistoryPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override ApplicantWorkHistoryPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<ApplicantWorkHistoryPoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(ApplicantWorkHistoryPoco[] pocos)
        {
            base.Update(pocos);
        }

        protected override void Verify(ApplicantWorkHistoryPoco[] pocos)
        {
            //ApplicantWorkHistoryLogic CompanyName Must be greater then 2 characters   105
            List<ValidationException> exception = new List<ValidationException>();
            foreach (var poco in pocos)
            {
                if(poco.CompanyName.Length <=2)
                {
                    exception.Add(new ValidationException(105, "ApplicantWorkHistoryLogic CompanyName Must be greater then 2 characters"));
                }
            }
           if(exception.Count>0)
            {
                throw new AggregateException(exception);
            }
        }
    }
}
