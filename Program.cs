using EntityFramworkTask1.Contoller;
using EntityFramworkTask1.Contoller.InventoryController;
using EntityFramworkTask1.Model;
using EntityFramworkTask1.Model.ManyToMany;
using EntityFramworkTask1.Model.OneToOne;
using Microsoft.EntityFrameworkCore;

namespace EntityFramworkTask1
{
    internal class Program
    {
        private static object productController;

        static void Main(string[] args)
        {
            #region Person

            #region Person Model class object
            //PersonModelClass person = new PersonModelClass()
            //{
            //    Name = "yuvi"
            //};
            #endregion

            //PersonController personController = new PersonController();

            #region AddPerson
            //personController.AddPerson(person);
            #endregion

            #region UpdatePerson
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
            #endregion

            #region DeletePerson
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

            #endregion

            #region Passport

            #region Passport Model class object
            //person = personController.GetPersonByName("kedar");
            //PassportModelClass passport = new PassportModelClass()
            //{
            //    PassportNumber = "aa3dd2",
            //    ExpiryDate = DateTime.Now,
            //    Person = person
            //};
            //person.Passport = passport;
            #endregion

            //PassportController pc = new PassportController();

            #region AddPassport
            //pc.AddPassport(passport);
            #endregion

            #region UpdatePassport
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
            #endregion

            #region DeletePassport
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

            #endregion

            #region PersonWithPassport
            //using (var db = new PassportContext())
            //{
            //    var personwithpassort = db.Persons.Include(p => p.Passport).ToList();

            //    foreach (var person1 in personwithpassort)
            //    {
            //        Console.Write($"{person1.Id} | ");
            //        Console.Write($"{person1.Name} | ");
            //        if (person1.Passport != null)
            //        {
            //            Console.Write($"{person1.Passport.PassportNumber} | ");
            //            Console.Write($"{person1.Passport.ExpiryDate}");
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            Console.Write("No Passport Found");
            //            Console.WriteLine();
            //        }
            //    }
            //}
            #endregion

            #region Inventory

            #region Product

            #region Product and Customer Model class object
            //ProductModelClass product = new ProductModelClass()
            //{
            //    ProductName = "Watch",
            //    ProductPrice = 1000
            //};
            //CustomerModelClass customer = new CustomerModelClass()
            //{
            //    CustomerName = "raj",
            //};
            #endregion

            //ProductController productController = new ProductController();

            #region AddProduct
            //productController.AddProduct(product);
            //var products = productController.GetProducts();
            //foreach (var product1 in products)
            //{
            //    Console.Write($"{product1.ProductId} | ");
            //    Console.Write($"{product1.ProductName} | ");
            //    Console.Write($"{product1.ProductPrice}");
            //    Console.WriteLine();
            //}
            #endregion

            #region UpdateProduct
            //Console.WriteLine("Enter the id to Update");
            //int id = Convert.ToInt32(Console.ReadLine());
            //var producttemp = productController.GetProductById(id);
            //productController.UpdateProduct(producttemp);
            //products = productController.GetProducts();
            //foreach (var product1 in products)
            //{
            //    Console.Write($"{product1.ProductId} | ");
            //    Console.Write($"{product1.ProductName} | ");
            //    Console.Write($"{product1.ProductPrice}");
            //    Console.WriteLine();
            //}
            #endregion

            #region DeleteProduct
            //Console.WriteLine("Enter the id to Delete");
            //int deleteid = Convert.ToInt32(Console.ReadLine());
            //productController.DeleteProduct(deleteid);
            //products = productController.GetProducts();

            //foreach (var product1 in products)
            //{
            //    Console.Write($"{product1.ProductId} | ");
            //    Console.Write($"{product1.ProductName} | ");
            //    Console.Write($"{product1.ProductPrice}");
            //    Console.WriteLine();
            //}
            #endregion

            #endregion

            #region Customer
            //CustomerController customerController = new CustomerController();

            #region AddCustomer
            //customerController.AddCustomer(customer);
            //var customers = customerController.GetCustomers();
            //foreach (var customer1 in customers)
            //{
            //    Console.Write($"{customer1.CustomerId} | ");
            //    Console.Write($"{customer1.CustomerName}");
            //    Console.WriteLine();
            //}
            #endregion

            #region UpdateCustomer
            //Console.WriteLine("Enter the id to Update");
            //int id1 = Convert.ToInt32(Console.ReadLine());
            //var customertemp = customerController.GetCustomerById(id1);
            //customertemp.CustomerName = "Ravi";
            //customerController.UpdateCustomer(customertemp);
            //var customers = customerController.GetCustomers();
            //Console.WriteLine("Customer Table");
            //Console.WriteLine(new string('-', 100));
            //foreach (var customer1 in customers)
            //{
            //    Console.Write($"{customer1.CustomerId} | ");
            //    Console.Write($"{customer1.CustomerName}");
            //    Console.WriteLine();
            //    Console.WriteLine(new string('-',100));
            //}
            #endregion

            #region DeleteCustomer
            //Console.WriteLine("Enter the id to Delete");
            //int deleteid1 = Convert.ToInt32(Console.ReadLine());
            //customerController.DeleteCustomer(deleteid1);
            //customers = customerController.GetCustomers();
            //foreach (var customer1 in customers)
            //{
            //    Console.Write($"{customer1.CustomerId} | ");
            //    Console.Write($"{customer1.CustomerName}");
            //    Console.WriteLine();
            //}
            #endregion

            #endregion

            #region Order

            #region Order Model class object
            //OrderModelClass order = new OrderModelClass()
            //{
            //    OrderDate = DateTime.Now,
            //    Customer = customer,
            //    Products = new List<ProductModelClass>()
            //    {
            //        product
            //    }
            //};
            #endregion

            //OrderController orderController = new OrderController();

            #region AddOrder
            //orderController.AddOrder(order);
            //var orders = orderController.GetOrders();
            //foreach (var order1 in orders)
            //{
            //    Console.Write($"{order1.OrderId} | ");
            //    Console.Write($"{order1.OrderDate} | ");
            //    Console.WriteLine();
            //}
            #endregion

            #region UpdateOrder
            //Console.WriteLine("Enter the id to Update");
            //int id2 = Convert.ToInt32(Console.ReadLine());
            //var ordertemp = orderController.GetOrderById(id2);
            //orderController.UpdateOrder(ordertemp);
            //orders = orderController.GetOrders();
            //foreach (var order1 in orders)
            //{
            //    Console.Write($"{order1.OrderId} | ");
            //    Console.Write($"{order1.OrderDate} | ");
            //    Console.Write($"{order1.Customer.CustomerName}");
            //    Console.WriteLine();
            //}
            #endregion

            #region DeleteOrder
            //Console.WriteLine("Enter the id to Delete");
            //int deleteid2 = Convert.ToInt32(Console.ReadLine());
            //orderController.DeleteOrder(deleteid2);
            //orders = orderController.GetOrders();
            //foreach (var order1 in orders)
            //{
            //    Console.Write($"{order1.OrderId} | ");
            //    Console.Write($"{order1.OrderDate} | ");
            //    Console.Write($"{order1.Customer.CustomerName}");
            //    Console.WriteLine();
            //}
            #endregion

            #endregion

            #region InventoryWithOrder
            using (var db = new InventoryContext())
            {
                var orderswithproducts = db.Orders.Include(x => x.Customer).Include(p => p.Products).ToList();
                Console.WriteLine("All Details:");
                Console.WriteLine(new string('-', 100));
                foreach (var order1 in orderswithproducts)
                {
                    Console.Write($"{order1.OrderId} | ");
                    Console.Write($"{order1.OrderDate} | ");
                    Console.Write($"{order1.Customer.CustomerName} | ");
                    foreach (var product1 in order1.Products)
                    {
                        Console.Write($"{product1.ProductName} | ");
                        Console.Write($"{product1.ProductPrice} | ");
                    }
                    Console.WriteLine();
                    Console.WriteLine(new string('-', 100));
                }
            }

            #endregion

            #endregion

        }
    }
}