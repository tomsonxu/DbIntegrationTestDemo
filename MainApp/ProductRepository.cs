using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class ProductRepository
    {
        private MyContext context;

        public ProductRepository(MyContext context)
        {
            this.context = context;
        }

        public void addProduct()
        {
            context.Products.Add(new Product { Name = "product 1" });
            context.SaveChanges();
        }

        public int getProductCount()
        {
            return context.Products.Count();
        }
    }
}
