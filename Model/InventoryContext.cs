using EntityFramworkTask1.Model.ManyToMany;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Model
{
    internal class InventoryContext : DbContext
    {
        public DbSet<ProductModelClass> Products { get; set; }
        public DbSet<CustomerModelClass> Customers { get; set; }
        public DbSet<OrderModelClass> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source=LAPTOP-CMODSAPH\\SQLEXPRESS;Initial Catalog=Infinnium;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
