using MainApp;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbIntegrationTestWithNUnit
{
    public class TestDbInitializer : DropCreateDatabaseAlways<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            base.Seed(context);
        }
    }
}
