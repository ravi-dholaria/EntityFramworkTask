using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Model.ManyToMany
{
    internal class OrderModelClass
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public CustomerModelClass Customer { get; set; }
        public ICollection<ProductModelClass> Products { get; set; }
    }
}
