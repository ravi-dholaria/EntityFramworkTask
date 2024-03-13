using EntityFramworkTask1.Model;
using EntityFramworkTask1.Model.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Dal.InventoryDal
{
    internal class ProductDal
    {
        #region AddProduct
        public void AddProduct(ProductModelClass product)
        {
            using (var context = new InventoryContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        #endregion

        #region GetProducts
        public List<ProductModelClass> GetProducts()
        {
            using (var context = new InventoryContext())
            {
                return context.Products.ToList();
            }
        }
        #endregion

        #region UpdateProduct
        public void UpdateProduct(ProductModelClass product)
        {
            using (var context = new InventoryContext())
            {
                context.Products.Update(product);
                context.SaveChanges();
            }
        }
        #endregion

        #region DeleteProduct
        public void DeleteProduct(int id)
        {
            using (var context = new InventoryContext())
            {
                var product = context.Products.Find(id);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
        #endregion

        #region GetProductById
        public ProductModelClass GetProductById(int id)
        {
            using (var context = new InventoryContext())
            {
                return context.Products.Find(id);
            }
        }
        #endregion
    }
}
