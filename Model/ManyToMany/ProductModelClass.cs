using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Model.ManyToMany
{
    internal class ProductModelClass
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only numbers are allowed.")]
        public int ProductPrice { get; set; }

        // Navigation property
        public ICollection<OrderModelClass> Orders { get; set; }
        public ICollection<CustomerModelClass> Customers { get; set; }
    }
}
