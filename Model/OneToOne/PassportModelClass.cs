using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkTask1.Model.OneToOne
{
    internal class PassportModelClass
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string PassportNumber { get; set; }
        [Required]
        public DateTime ExpiryDate {  get; set; }
        public int PersonId { get; set; }
        public PersonModelClass Person { get; set; }
    }
}
