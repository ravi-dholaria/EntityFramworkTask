using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Model.ManyToMany
{
    internal class ProductModelClass
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public ICollection<OrderModelClass> Orders { get; set; }
        public ICollection<CustomerModelClass> Customers { get; set; }
    }
}
