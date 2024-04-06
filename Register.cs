using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1ef
{
    internal class Register
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Plase Enter 10 char...!"), MaxLength(10)]
        public string FirstName { get; set; }
        [Required (ErrorMessage ="Plase Enter 10 char ...!"), MaxLength(10)]
        public string LastName { get; set; }
        [Required (ErrorMessage ="Plase Enter Number Phone ...!"),MaxLength(11)]
        public int Numberphone { get; set; }
        [Required (ErrorMessage ="Plase Enter your Mail ...!")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }

        [Required (ErrorMessage ="Plase Enter your Number SSN int 14...!"), MaxLength(14)]
        public long SSN { get; set; }

        [Required (ErrorMessage ="Plase Enter your Password ...!"), MaxLength(8)]
        public string Password { get; set; }
        [Required,MaxLength(8)]
        public string confirmpaswword { get; set; }
        public DateTime DateTime { get; set; }

        //public virtual Login Login { get; set; }




    }
}
