using System;
using NUnit.Framework;

namespace DbIntegrationTestWithNUnit
{
    [SetUpFixture]
    public class TestGlobal
    {
        [SetUp]
        public void setup()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
            System.Data.Entity.Database.SetInitializer(new TestDbInitializer());
        }
    }
}
