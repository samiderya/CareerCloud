﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
   public class ApplicantResumeLogic:BaseLogic<ApplicantResumePoco>
    {
        public ApplicantResumeLogic(IDataRepository<ApplicantResumePoco> repository) : base(repository)
        {

        }

        public override void Add(ApplicantResumePoco[] pocos)
        {
            Verify(pocos);
            foreach (var poco in pocos)
            {
                poco.Resume = poco.Resume;
              

            }
            base.Add(pocos);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override ApplicantResumePoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<ApplicantResumePoco> GetAll()
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

        public override void Update(ApplicantResumePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(ApplicantResumePoco[] pocos)
        {
            //ApplicantResumeLogic Resume  Resume cannot be empty  113
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (var poco in pocos)
            {
                if(string.IsNullOrEmpty(poco.Resume))
                {
                    exceptions.Add(new ValidationException(107, $"Resume for ApplicantResumeLogic cannot be null"));
                }

            }
            base.Verify(pocos);
        }
    }
}
