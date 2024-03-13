using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Model.ManyToMany
{
    internal class OrderModelClass
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        // Foreign Key
        public int CustomerId { get; set; }

        // Navigation property 
        public CustomerModelClass Customer { get; set; }
        public ICollection<ProductModelClass> Products { get; set; }
    }
}
