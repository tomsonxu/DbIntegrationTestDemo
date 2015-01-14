using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            ProductRepository dao = new ProductRepository(context);
            dao.addProduct();
            Console.WriteLine("existing product count = " + dao.getProductCount());
            Console.Read();
        }
    }
}
