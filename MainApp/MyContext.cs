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
        public MyContext() : base("DemoDB") {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<Product> Products { get; set; }
    }
}
