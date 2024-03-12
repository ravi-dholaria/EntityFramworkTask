using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Model.OneToOne
{
    internal class PersonModelClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public PassportModelClass Passport { get; set; }
    }
}
