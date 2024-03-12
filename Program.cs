using EntityFramworkTask1.Contoller;
using EntityFramworkTask1.Model.OneToOne;

namespace EntityFramworkTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Person
            //PersonModelClass person = new PersonModelClass()
            //{
            //    Name = "Kedar"
            //};
            //PersonController personController = new PersonController();
            //personController.AddPerson(person);
            //Console.WriteLine("Enter the id to Update");
            //int id = Convert.ToInt32(Console.ReadLine());
            //personController.UpdatePerson(id);
            //var persons = personController.GetPerson();
            //foreach (var person1 in persons)
            //{
            //    Console.Write($"{person1.Id} | ");
            //    Console.Write($"{person1.Name}");
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Enter the id to Delete");
            //int deleteid = Convert.ToInt32(Console.ReadLine());
            //personController.DeletePerson(deleteid);
            //persons = personController.GetPerson();
            //foreach (var person1 in persons)
            //{
            //    Console.Write($"{person1.Id} | ");
            //    Console.Write($"{person1.Name}");
            //    Console.WriteLine();
            //}
            #endregion

            #region Passport
            //person = personController.GetPersonByName("kedar");
            //PassportModelClass passport = new PassportModelClass()
            //{
            //    PassportNumber = "123dd2",
            //    ExpiryDate = DateTime.Now,
            //    PersonId = person.Id
            //};
            
            //PassportController pc = new PassportController();

            //pc.AddPassport(passport);

            //Console.WriteLine("Enter the id to Update");
            //int updateid = Convert.ToInt32(Console.ReadLine());
            //pc.UpdatePassport(updateid);

            //var passports = pc.GetPassports();
            //foreach (var passport1 in passports)
            //{
            //    Console.Write($"{passport1.PassportNumber} | ");
            //    Console.Write($"{passport1.ExpiryDate} | ");
            //    Console.Write($"{passport1.PersonId}");
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter the id to Delete");
            //int deleteid = Convert.ToInt32(Console.ReadLine());
            //pc.DeletePassport(deleteid);
            //passports = pc.GetPassports();
            //foreach (var passport1 in passports)
            //{
            //    Console.Write($"{passport1.PassportNumber} | ");
            //    Console.Write($"{passport1.ExpiryDate} | ");
            //    Console.Write($"{passport1.PersonId}");
            //    Console.WriteLine();
            //}
            #endregion


        }
    }
}