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
        public void AddPassport(PassportModelClass passport,PersonModelClass person)
        {
            using(var db = new PassportContext())
            {
                db.Persons.Add(person);
                db.SaveChanges();
                passport.PersonId = person.Id;
                db.Passports.Add(passport);
                db.SaveChanges();
            }
        }
        #endregion
    }
}
