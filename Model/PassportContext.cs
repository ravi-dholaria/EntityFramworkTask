using EntityFramworkTask1.Model.OneToOne;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Model
{
    internal class PassportContext : DbContext
    {
        public DbSet<PassportModelClass> Passports { get; set; }
        public DbSet<PersonModelClass> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source=LAPTOP-CMODSAPH\\SQLEXPRESS;Initial Catalog=Infinnium;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
