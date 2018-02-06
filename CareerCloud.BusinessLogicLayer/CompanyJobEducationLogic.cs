using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyJobEducationLogic : BaseLogic<CompanyJobEducationPoco>
    {
        public CompanyJobEducationLogic(IDataRepository<CompanyJobEducationPoco> repository) : base(repository)
        {
        }

        public override void Add(CompanyJobEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override CompanyJobEducationPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<CompanyJobEducationPoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(CompanyJobEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyJobEducationPoco[] pocos)
        {
            //Major must be at least 2 characters 200
            //Importance cannot be less than 0    201

            List<ValidationException> exception = new List<ValidationException>();
            foreach (var poco in pocos)
            {
                if(poco.Major.Length<=2)
                {
                    exception.Add(new ValidationException(200, "Major must be at least 2 characters"));
                }
                else if(poco.Importance<0)
                {
                    exception.Add(new ValidationException(201, "Importance cannot be less than 0"));
                }
            }
            if(exception.Count>0)
            {
                throw new AggregateException(exception);
            }
        }
    }
}
