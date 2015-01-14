using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DbIntegrationTestWithMSTest
{
    [TestClass]
    public class TestGlobal
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
            System.Data.Entity.Database.SetInitializer(new TestDbInitializer());
        }
    }
}
