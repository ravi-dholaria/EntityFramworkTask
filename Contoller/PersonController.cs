using EntityFramworkTask1.Dal;
using EntityFramworkTask1.Model.OneToOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Contoller
{
    internal class PersonController
    {
        #region AddPerson
        public void AddPerson(PersonModelClass person)
        {
            PersonDal personDal = new PersonDal();
            personDal.AddPerson(person);
        }
        #endregion

        #region GetPerson
        public List<PersonModelClass> GetPerson()
        {
            PersonDal personDal = new PersonDal();
            return personDal.GetPerson();
        }
        #endregion

        #region UpdatePerson
        public void UpdatePerson(int Id)
        {
            PersonDal personDal = new PersonDal();
            var person = personDal.GetPerson().Find(x => x.Id == Id);
            person.Name = "Ravi";
            personDal.UpdatePerson(person);
        }
        #endregion

        #region DeletePerson
        public void DeletePerson(int Id)
        {
            PersonDal personDal = new PersonDal();
            var person = personDal.GetPerson().Find(x => x.Id == Id);
            personDal.DeletePerson(person);
        }
        #endregion  

        #region GetPersonByName
        public PersonModelClass GetPersonByName(string name)
        {
            PersonDal personDal = new PersonDal();
            return personDal.GetPersonByName(name);
        }
        #endregion
    }
}
