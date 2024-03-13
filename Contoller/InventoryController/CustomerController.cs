using EntityFramworkTask1.Dal.InventoryDal;
using EntityFramworkTask1.Model.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Contoller.InventoryController
{
    internal class CustomerController
    { //use CustomerDal class and it methods
        #region AddCustomer
        public void AddCustomer(CustomerModelClass customer)
        {
            var db = new CustomerDal();
            db.AddCustomer(customer);
        }
        #endregion

        #region GetCustomers
        public List<CustomerModelClass> GetCustomers()
        {
            var db = new CustomerDal();
            return db.GetCustomers();
        }
        #endregion

        #region UpdateCustomer
        public void UpdateCustomer(CustomerModelClass customer)
        {
            var db = new CustomerDal();
            db.UpdateCustomer(customer);
        }
        #endregion

        #region DeleteCustomer
        public void DeleteCustomer(int id)
        {
            var db = new CustomerDal();
            db.DeleteCustomer(id);
        }
        #endregion

        #region GetCustomerById
        public CustomerModelClass GetCustomerById(int id)
        {
            var db = new CustomerDal();
            return db.GetCustomerById(id);
        }
        #endregion
    }
}
