using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class Contexto : DbContext
    {
        public Contexto() : base()
        {
           
        }
      


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        public DbSet<NuestrasPizzas> Nuestrapizzas { get; set; }

    }
}
