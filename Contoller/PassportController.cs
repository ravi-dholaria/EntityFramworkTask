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
        public void AddPassport(PassportModelClass passport)
        {
            var passportDal = new PassportDal();
            passportDal.AddPassport(passport);
        }
        #endregion

        #region GetPassports
        public List<PassportModelClass> GetPassports()
        {
            var passportDal = new PassportDal();
            return passportDal.GetPassport();
        }
        #endregion                        

        #region UpdatePassport
        public void UpdatePassport(int id)
        {
            var passportDal = new PassportDal();
            var passport = passportDal.GetPassport().Find( x => x.Id == id);
            passport.PassportNumber = "111111";
            passportDal.UpdatePassport(passport);
        }
        #endregion

        #region DeletePassport
        public void DeletePassport(int id)
        {
            var passportDal = new PassportDal();
            var passport = passportDal.GetPassport().Find( x => x.Id == id);
            passportDal.DeletePassport(passport);
        }
        #endregion
    }
}
