using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyDescriptionLogic : BaseLogic<CompanyDescriptionPoco>
    {
        public CompanyDescriptionLogic(IDataRepository<CompanyDescriptionPoco> repository) : base(repository)
        {
        }

        public override void Add(CompanyDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override CompanyDescriptionPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<CompanyDescriptionPoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(CompanyDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyDescriptionPoco[] pocos)
        {
            //CompanyDescription must be greater than 2 characters    107
            //CompanyName must be greater than 2 characters   106
            List<ValidationException> exception = new List<ValidationException>();
            foreach (var poco in pocos)
            {
                if( !string.IsNullOrEmpty(poco.CompanyDescription) &&  poco.CompanyDescription.Length<=2)
                {
                    exception.Add(new  ValidationException(107, "CompanyDescription must be greater than 2 characters"));
                }
                if(!string.IsNullOrEmpty(poco.CompanyName) && poco.CompanyName.Length<=2)
                {
                    exception.Add(new ValidationException(106, "CompanyName must be greater than 2 characters"));
                }
            }
            if(exception.Count>0)
            {
                throw new AggregateException(exception);
            }
        }
    }
}
