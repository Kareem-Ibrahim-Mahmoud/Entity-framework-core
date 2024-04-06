using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1ef
{
    internal class Context : DbContext
    {

        public DbSet<Login> logins { get; set; }    
        public DbSet<Register> register { get; set; }   
        public DbSet<Employee> employees { get; set; }
        public DbSet <Money> moneys { get; set; }   


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=.;Initial catalog=Entity;Integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
