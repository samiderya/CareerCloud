using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemCountryCodeLogic 
    {
        readonly IDataRepository<SystemCountryCodePoco> _repository;
        public SystemCountryCodeLogic(IDataRepository<SystemCountryCodePoco> repository) 
        {
            this._repository = repository;
        }

        public void Add(SystemCountryCodePoco[] pocos)
        {
              Verify(pocos);
            _repository.Add(pocos);
        }
      
        
        public void Update(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            _repository.Update(pocos);
        }

        protected void Verify(SystemCountryCodePoco[] pocos)
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
                if(string.IsNullOrEmpty(poco.Name))
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
