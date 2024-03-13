using EntityFramworkTask1.Dal.InventoryDal;
using EntityFramworkTask1.Model.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Contoller.InventoryController
{
    internal class OrderController
    {
        #region AddOrder
        public void AddOrder(OrderModelClass order)
        {
            var db = new OrderDal();
            db.AddOrder(order);
        }
        #endregion

        #region GetOrders
        public List<OrderModelClass> GetOrders()
        {
            var db = new OrderDal();
            return db.GetOrders();
        }
        #endregion

        #region UpdateOrder
        public void UpdateOrder(OrderModelClass order)
        {
            var db = new OrderDal();
            db.UpdateOrder(order);
        }
        #endregion

        #region DeleteOrder
        public void DeleteOrder(int id)
        {
            var db = new OrderDal();
            db.DeleteOrder(id);
        }
        #endregion

        #region GetOrderById
        public OrderModelClass GetOrderById(int id)
        {
            var db = new OrderDal();
            return db.GetOrderById(id);
        }
        #endregion

    }
}
