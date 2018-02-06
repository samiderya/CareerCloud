using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantProfileLogic : BaseLogic<ApplicantProfilePoco>
    {
        public ApplicantProfileLogic(IDataRepository<ApplicantProfilePoco> repository):base(repository)
        {

        }
        
        public override void Add(ApplicantProfilePoco[] pocos)
        {
            Verify(pocos);
            foreach (ApplicantProfilePoco poco in pocos)
            {
                //poco.Applicant = poco.Applicant;
                //poco.Major = poco.Major;
                //poco.CertificateDiploma = poco.CertificateDiploma;
                //poco.StartDate = poco.StartDate;
                //poco.CompletionDate = poco.CompletionDate;
                //poco.CompletionPercent = poco.CompletionPercent;
            }
                base.Add(pocos);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override ApplicantProfilePoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<ApplicantProfilePoco> GetAll()
        {
            return base.GetAll();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Update(ApplicantProfilePoco[] pocos)
        {
            base.Update(pocos);
        }

        protected override void Verify(ApplicantProfilePoco[] pocos)
        {
             //ApplicantProfileLogic CurrentSalary   CurrentSalary cannot be negative    111
             //ApplicantProfileLogic CurrentRate CurrentRate cannot be negative  112

            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (var poco in pocos)
            {
                if (poco.CurrentSalary<0)
                {
                    exceptions.Add(new ValidationException(111, $"ApplicantProfileLogic CurrentSalary cannot be negative "));
                }
                else if (poco.CurrentRate<0)
                {
                    exceptions.Add(new ValidationException(112, $"ApplicantProfileLogic CurrentRate cannot be negative."));
                }
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
