using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class MyContext : DbContext
    {
        public MyContext() : base("DemoDB") { }
        public DbSet<Product> Products { get; set; }
    }
}
