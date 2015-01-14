using System;
using System.Linq;
using MainApp;
using NUnit.Framework;

namespace DbIntegrationTestWithNUnit
{
    [TestFixture]
    public class ProductRepositoryTest
    {
        [SetUp]
        public void setup()
        {
            MyContext context = new MyContext();
            context.Database.Initialize(true);  //very important, it may make db initialize before every test!!
        }

        [Test]
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
