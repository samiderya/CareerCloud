﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class SecurityLoginsLogLogic : BaseLogic<SecurityLoginsLogPoco>
    {
        public SecurityLoginsLogLogic(IDataRepository<SecurityLoginsLogPoco> repository) : base(repository)
        {
        }

        public override void Add(SecurityLoginsLogPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override SecurityLoginsLogPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<SecurityLoginsLogPoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(SecurityLoginsLogPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(SecurityLoginsLogPoco[] pocos)
        {
            base.Verify(pocos);
        }
    }
}