using EntityFramworkTask1.Model;
using EntityFramworkTask1.Model.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Dal.InventoryDal
{
    internal class OrderDal
    {
        #region AddOrder
        public void AddOrder(OrderModelClass order)
        {
            using (var context = new InventoryContext())
            {
                var customer = context.Customers.Find(order.Customer.CustomerId);
                List<ProductModelClass> products = new List<ProductModelClass>();
                foreach (var item in order.Products)
                {
                    products.Add(context.Products.Find(item.ProductId));
                }
                order.Products = products;
                order.Customer = customer;

                context.Orders.Add(order);
                context.SaveChanges();
            }
        }
        #endregion

        #region GetOrders
        public List<OrderModelClass> GetOrders()
        {
            using (var context = new InventoryContext())
            {
                return context.Orders.ToList();
            }
        }
        #endregion

        #region UpdateOrder
        public void UpdateOrder(OrderModelClass order)
        {
            using (var context = new InventoryContext())
            {
                context.Orders.Update(order);
                context.SaveChanges();
            }
        }
        #endregion

        #region DeleteOrder
        public void DeleteOrder(int id)
        {
            using (var context = new InventoryContext())
            {
                var order = context.Orders.Find(id);
                context.Orders.Remove(order);
                context.SaveChanges();
            }
        }
        #endregion

        #region GetOrderById
        public OrderModelClass GetOrderById(int id)
        {
            using (var context = new InventoryContext())
            {
                return context.Orders.Find(id);
            }
        }
        #endregion
    }
}
