using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.WebApiTest.Data
{
    public class Department
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        // public ICollection<User> Users { get; set; }
    }
}
