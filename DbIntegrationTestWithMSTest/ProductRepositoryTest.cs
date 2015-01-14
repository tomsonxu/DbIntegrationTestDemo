using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainApp;


namespace DbIntegrationTestWithMSTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestInitialize]
        public void setup()
        {
            MyContext context = new MyContext();
            context.Database.Initialize(true);  //very important, it may make db initialize before every test!!
        }

        [TestMethod]
        public void Test_AddProduct()
        {
            using (var context = new MyContext())
            {
                ProductRepository repository = new ProductRepository(context);
                repository.addProduct();
            }

            using (var context = new MyContext())
            {
                Assert.AreEqual(1, context.Products.Count());
            }
        }

    }
}
