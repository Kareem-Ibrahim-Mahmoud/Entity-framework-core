using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1ef
{
    internal class Employee
    {
        [Required]
        public int Id { get; set; }
       // [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public int Numberphone { get; set; }
        public string Address { get; set; }
        public float salary { get; set; }
        [Required,MaxLength(14)]
        public long SSN { get; set; }
        [Required]
        public string sheft { get; set; }
        
        public virtual Department_and_name_manager dep { get; set; }
        public virtual Money Money { get; set; }


        public void mone(float ass)
        {
            Money money = new Money();

            ass = salary + money.blus_salary;
            
        }

    }
}
