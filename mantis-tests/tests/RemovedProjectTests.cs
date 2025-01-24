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



            AccountData account = new AccountData()
            {
                AccountName = "Administrator",
                Password = "root"
            };

            List<ProjectData> oldProjectList = app.API.ListApiProjetData(account);
            if (oldProjectList.Count == 0)
            {
                    AccountData account2 = new AccountData()
                    {
                        AccountName = "Administrator",
                        Password = "root"
                    };

                    app.API.CreateApiProjet(account2);

            }

            app.ManagementMenuHelper.Control();
            app.ManagementMenuHelper.ProjectsTab();
            List<ProjectData> oldProjectList2 = app.API.ListApiProjetData(account);
            ///List<ProjectData> oldProjectList = app.ProjectManagementHelper.GetProjectList();

            ProjectData ToBeRemoved = oldProjectList2[0];

            app.ProjectManagementHelper.SelectProject();
            app.ProjectManagementHelper.DeleteProject();
            app.ProjectManagementHelper.CommitDeleteProject();

            //List<ProjectData> newProjectList = app.ProjectManagementHelper.GetProjectList();
            List<ProjectData> newProjectList = app.API.ListApiProjetData(account);

            oldProjectList2.Remove(ToBeRemoved);

            oldProjectList.Sort();
            newProjectList.Sort();
            Assert.AreEqual(oldProjectList2, newProjectList);

            app.ProjectManagementHelper.ExitMantis();
        }
    }
}
