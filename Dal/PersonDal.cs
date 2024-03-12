using EntityFramworkTask1.Model;
using EntityFramworkTask1.Model.OneToOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Dal
{
    internal class PersonDal
    {
        #region AddPerson
        public void AddPerson(PersonModelClass person)
        {
            using (var context = new PassportContext())
            {
                context.Persons.Add(person);
                context.SaveChanges();
            }
        }
        #endregion

        #region GetPerson
        public List<PersonModelClass> GetPerson()
        {
            using (var context = new PassportContext())
            {
                return context.Persons.ToList();
            }
        }
        #endregion

        #region UpdatePerson
        public void UpdatePerson(PersonModelClass person)
        {
            using (var context = new PassportContext())
            {
                context.Persons.Update(person);
                context.SaveChanges();
            }
        }
        #endregion

        #region DeletePerson
        public void DeletePerson(PersonModelClass person)
        {
            using (var context = new PassportContext())
            {
                context.Persons.Remove(person);
                context.SaveChanges();
            }
        }
        #endregion

        #region GetPersonByName
        public PersonModelClass GetPersonByName(string name)
        {
            using (var context = new PassportContext())
            {
                return context.Persons.FirstOrDefault(x => x.Name == name);
            }
        }
        #endregion

    }
}
