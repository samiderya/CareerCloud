using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantEducationLogic : BaseLogic<ApplicantEducationPoco>
    {
        private const int saltLengthLimit = 10;

        public ApplicantEducationLogic(IDataRepository<ApplicantEducationPoco> repository) : base(repository)
        {
        }
        public override void Add(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            foreach (ApplicantEducationPoco poco in pocos)
            {
                poco.Applicant = poco.Applicant;
                poco.Major = poco.Major;
                poco.CertificateDiploma = poco.CertificateDiploma;
                poco.StartDate = poco.StartDate;
                poco.CompletionDate = poco.CompletionDate;
                poco.CompletionPercent = poco.CompletionPercent;
            }
            base.Add(pocos);
        }

      
        public override ApplicantEducationPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<ApplicantEducationPoco> GetAll()
        {
            return base.GetAll();
        }

      
        public override void Update(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(ApplicantEducationPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (var poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.Major) || poco.Major.Length < 3)
                {
                    exceptions.Add(new ValidationException(107, $"Major for ApplicationEducation {poco.Id} Cannot be empty or less than 3 characters"));
                }
                else if (poco.StartDate > DateTime.Now)
                {
                    exceptions.Add(new ValidationException(108, $"StartDate for ApplicationEducation {poco.Id} Cannot be greater than today."));
                }
                else if(poco.CompletionDate < poco.StartDate)
                {
                    exceptions.Add(new ValidationException(109, $"CompletionDate for ApplicationEducation {poco.Id} CompletionDate cannot be earlier than StartDate."));
                }
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
