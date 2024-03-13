using EntityFramworkTask1.Model;
using EntityFramworkTask1.Model.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Dal.InventoryDal
{
    internal class CustomerDal
    {
        #region AddCustomer
        public void AddCustomer(CustomerModelClass customer)
        {
            using (var context = new InventoryContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }
        #endregion

        #region getCustomers
        public List<CustomerModelClass> GetCustomers()
        {
            using (var context = new InventoryContext())
            {
                return context.Customers.ToList();
            }
        }
        #endregion

        #region UpdateCustomer
        public void UpdateCustomer(CustomerModelClass customer)
        {
            using (var context = new InventoryContext())
            {
                context.Customers.Update(customer);
                context.SaveChanges();
            }
        }
        #endregion

        #region DeleteCustomer
        public void DeleteCustomer(int id)
        {
            using (var context = new InventoryContext())
            {
                var customer = context.Customers.Find(id);
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
        #endregion

        #region GetCustomerById
        public CustomerModelClass GetCustomerById(int id)
        {
            using (var context = new InventoryContext())
            {
                return context.Customers.Find(id);
            }
        }
        #endregion
    }
}
