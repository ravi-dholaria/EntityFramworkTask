using EntityFramworkTask1.Dal;
using EntityFramworkTask1.Model.OneToOne;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Contoller
{
    internal class PassportController
    {
        #region AddPassport
        public void AddPassport()
        {
            var person = new PersonModelClass
            {
                Name = "John"
            };
            var passport = new PassportModelClass
            {
                PassportNumber = "123456",
                ExpiryDate = DateTime.Now,
            };
            var passportDal = new PassportDal();
            passportDal.AddPassport(passport,person);
        }
        #endregion
    }
}
