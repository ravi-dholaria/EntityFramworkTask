using EntityFramworkTask1.Model;
using EntityFramworkTask1.Model.OneToOne;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Dal
{
    internal class PassportDal
    {
        #region AddPassport
        public void AddPassport(PassportModelClass passport)
        {
            using(var db = new PassportContext())
            {
                db.Passports.Add(passport);
                db.SaveChanges();
            }
        }
        #endregion

        #region GetPassport
        public List<PassportModelClass> GetPassport()
        {
            using (var db = new PassportContext())
            {
                return db.Passports.ToList();
            }
        }
        #endregion

        #region UpdatePassport
        public void UpdatePassport(PassportModelClass passport)
        {
            using (var db = new PassportContext())
            {
                db.Passports.Update(passport);
                db.SaveChanges();
            }
        }
        #endregion

        #region DeletePassport
        public void DeletePassport(PassportModelClass passport)
        {
            using (var db = new PassportContext())
            {
                db.Passports.Remove(passport);
                db.SaveChanges();
            }
        }
        #endregion
    }
}
