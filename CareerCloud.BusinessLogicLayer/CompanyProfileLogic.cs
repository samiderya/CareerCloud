using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyProfileLogic : BaseLogic<CompanyProfilePoco>
    {
        public CompanyProfileLogic(IDataRepository<CompanyProfilePoco> repository) : base(repository)
        {
        }

        public override void Add(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override CompanyProfilePoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<CompanyProfilePoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyProfilePoco[] pocos)
        {
            //Valid websites must end with the following extensions – ".ca", ".com", ".biz"   600
            //Must correspond to a valid phone number(e.g. 416 - 555 - 1234) 601

            List<ValidationException> exceptions = new List<ValidationException>();
            string[] requiredWebsiteExtensions = new string[] { ".ca", ".com", ".biz" };
            foreach (var poco in pocos)
            {
                if (!string.IsNullOrEmpty(poco.CompanyWebsite) && !requiredWebsiteExtensions.Any(t => poco.CompanyWebsite.Contains(t)))
                {
                    exceptions.Add(new ValidationException(600, @"Valid websites must end with the following extensions – '.ca', '.com', '.biz' "));
                }
                  
                    string[] phoneComponents = !string.IsNullOrEmpty(poco.ContactPhone) ? poco.ContactPhone.Split('-') : new string[] { "0"};
                    if (phoneComponents.Length < 3)
                    {
                        exceptions.Add(new ValidationException(601, $"PhoneNumber for CompanyProfileLogic {poco.Id} is not in the required format((e.g. 416 - 555 - 1234))."));
                    }
                    else
                    {
                        if (phoneComponents[0].Length < 3)
                        {
                            exceptions.Add(new ValidationException(601, $"PhoneNumber for CompanyProfileLogic {poco.Id} is not in the required format(e.g. 416 - 555 - 1234)."));
                        }
                        else if (phoneComponents[1].Length < 3)
                        {
                            exceptions.Add(new ValidationException(601, $"PhoneNumber for CompanyProfileLogic {poco.Id} is not in the required format(e.g. 416 - 555 - 1234)."));
                        }
                        else if (phoneComponents[2].Length < 4)
                        {
                            exceptions.Add(new ValidationException(601, $"PhoneNumber for CompanyProfileLogic {poco.Id} is not in the required format(e.g. 416 - 555 - 1234)."));
                        }
                    }
                


            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

    }
}
