using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace mantis_tests
{
    [TestFixture]
    public class ListApiProjectTests : TestBase
    {

        [Test]

        public void ListApiProjectTest1()
        {
            AccountData account = new AccountData()
            {
                AccountName = "Administrator",
                Password ="root"
            };

            List<ProjectData>  test = app.API.ListApiProjetData(account);

        }



        [Test]

        public void CreateApiProjectTest2()
        {
            AccountData account = new AccountData()
            {
                AccountName = "Administrator",
                Password = "root"
            };

            app.API.CreateApiProjet(account);

        }



    }
}

