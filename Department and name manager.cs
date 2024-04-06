using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1ef
{
    internal class Department_and_name_manager
    {
        public int ID { get; set; }
        public string Dept { get; set; }
        public string deptnamemanger { get; set; }
        public virtual ICollection<Employee> emp { get; set; }
        public virtual ICollection<Register> register { get; set; } 
        public virtual ICollection <Money> money { get; set; }

    }
}
