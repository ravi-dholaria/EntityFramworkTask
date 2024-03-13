using EntityFramworkTask1.Dal.InventoryDal;
using EntityFramworkTask1.Model.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Contoller.InventoryController
{
    internal class ProductController
    {
        #region AddProduct
        public void AddProduct(ProductModelClass product)
        {
            var db = new ProductDal();
            db.AddProduct(product);
        }
        #endregion

        #region GetProducts
        public List<ProductModelClass> GetProducts()
        {
            var db = new ProductDal();
            return db.GetProducts();
        }
        #endregion

        #region UpdateProduct
        public void UpdateProduct(ProductModelClass product)
        {
            var db = new ProductDal();
            db.UpdateProduct(product);
        }
        #endregion

        #region DeleteProduct
        public void DeleteProduct(int id)
        {
            var db = new ProductDal();
            db.DeleteProduct(id);
        }
        #endregion

        #region GetProductById
        public ProductModelClass GetProductById(int id)
        {
            var db = new ProductDal();
            return db.GetProductById(id);
        }
        #endregion
    }
}
