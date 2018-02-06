using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyLocationLogic : BaseLogic<CompanyLocationPoco>
    {
        public CompanyLocationLogic(IDataRepository<CompanyLocationPoco> repository) : base(repository)
        {
        }

        public override void Add(CompanyLocationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override CompanyLocationPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<CompanyLocationPoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(CompanyLocationPoco[] pocos)
        {
            base.Update(pocos);
        }

        protected override void Verify(CompanyLocationPoco[] pocos)
        {
//CountryCode cannot be empty 500
//Province cannot be empty    501
//Street cannot be empty  502
//City cannot be empty    503
//PostalCode cannot be empty  504

            List<ValidationException> exception = new List<ValidationException>();
            foreach (var poco in pocos)
            {
                if(string.IsNullOrEmpty(poco.CountryCode))
                {
                    exception.Add(new ValidationException(500, "CountryCode cannot be empty"));
                }
                else if(string.IsNullOrEmpty(poco.Province))
                {
                    exception.Add(new ValidationException(501, "Province cannot be empty"));
                }
                else if(string.IsNullOrEmpty(poco.Street))
                {
                    exception.Add(new ValidationException(502, "Street cannot be empty"));
                }
                else if(string.IsNullOrEmpty(poco.City))
                {
                    exception.Add(new ValidationException(503, "City cannot be empty"));
                }
                else if(string.IsNullOrEmpty(poco.PostalCode))
                {
                    exception.Add(new ValidationException(504, "PostalCode cannot be empty"));
                }
            }
            if(exception.Count>0)
            {
                throw new AggregateException(exception);
            }
        }
    }
}
