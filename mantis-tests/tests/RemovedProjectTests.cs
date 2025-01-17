using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace mantis_tests
{
    [TestFixture]
    public class RemovedProjectTests : TestBase
    {
        [Test]
        public void RemovedProjectTest1() 
        {
            app.Auth.Login();
            app.ManagementMenuHelper.Control();
            app.ManagementMenuHelper.ProjectsTab();
            

            app.ProjectManagementHelper.SelectProject();
            app.ProjectManagementHelper.DeleteProject();
            app.ProjectManagementHelper.CommitDeleteProject();

            app.ProjectManagementHelper.ExitMantis();
        }
    }
}
