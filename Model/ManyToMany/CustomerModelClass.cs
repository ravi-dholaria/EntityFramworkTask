using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Model.ManyToMany
{
    internal class CustomerModelClass
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public ICollection<OrderModelClass> Orders { get; set; }
        public ICollection<ProductModelClass> Products { get; set; }
    }
}
