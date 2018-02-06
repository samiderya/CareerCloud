using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemCountryCodeLogic : BaseLogic<SystemCountryCodePoco>
    {
        public SystemCountryCodeLogic(IDataRepository<SystemCountryCodePoco> repository) : base(repository)
        {
        }

        public override void Add(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override SystemCountryCodePoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<SystemCountryCodePoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(SystemCountryCodePoco[] pocos)
        {
            //Code Cannot be empty 900
            //Name Cannot be empty 901

            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (var poco in pocos)
            {
                if(string.IsNullOrEmpty(poco.Code))
                {
                    exceptions.Add(new ValidationException(900,"Code Cannot be empty"));
                }
                else if(string.IsNullOrEmpty(poco.Name))
                {
                    exceptions.Add(new ValidationException(901,"Name Cannot be empty"));
                }
            }
            if(exceptions.Count>0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
