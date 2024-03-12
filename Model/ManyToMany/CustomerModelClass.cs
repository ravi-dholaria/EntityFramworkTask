using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Model.ManyToMany
{
    internal class CustomerModelClass
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public ICollection<OrderModelClass> Orders { get; set; }
        public ICollection<ProductModelClass> Products { get; set; }
    }
}
