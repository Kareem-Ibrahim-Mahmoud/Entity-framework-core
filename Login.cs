using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1ef
{
    internal class Login
    {
        public int Id { get; set; } 
        [Required]
        public string user { get; set; }
        [Required]
        public string password { get; set; }
        public long  SSN { get; set; }

        public virtual Register Register { get; set; }

        public void chekk()
        {
            Register register = new Register();

            if(SSN ==register.SSN)
            {
                

            }
            else
            {
                Exception exception = new Exception("You Must Make New Account ...!");
            }
        }



    }
}
