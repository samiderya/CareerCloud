using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemLanguageCodeLogic : BaseLogic<SystemLanguageCodePoco>
    {
        public SystemLanguageCodeLogic(IDataRepository<SystemLanguageCodePoco> repository) : base(repository)
        {
        }

        public override void Add(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override SystemLanguageCodePoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<SystemLanguageCodePoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(SystemLanguageCodePoco[] pocos)
        {
            //LanguageID Cannot be empty 1000
            //Name Cannot be empty 1001
            //NativeName Cannot be empty 1002

            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (var poco in pocos)
            {
                if(string.IsNullOrEmpty(poco.LanguageID))
                {
                    exceptions.Add(new ValidationException(1000, "LanguageID Cannot be empty"));
                }
                else if(string.IsNullOrEmpty(poco.Name))
                {
                    exceptions.Add(new ValidationException(1001,"Name Cannot be empty"));
                }
                else if(string.IsNullOrEmpty(poco.NativeName))
                {
                    exceptions.Add(new ValidationException(1002, "NativeName Cannot be empty"));
                }
            }
            if(exceptions.Count>0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
