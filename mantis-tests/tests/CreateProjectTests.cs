using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using mantis_tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V128.Page;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace mantis_tests
{
    [TestFixture]
    public class CreateProjectTests :TestBase
    {
       

        [Test]
        public void CreateProjectTest1()
        {
            app.Auth.Login();
            app.ManagementMenuHelper.Control();
            app.ManagementMenuHelper.ProjectsTab();


            AccountData account = new AccountData()
            {
                AccountName = "Administrator",
                Password = "root"
            };

            List<ProjectData> oldProjectList = app.API.ListApiProjetData(account);
          //List<ProjectData> oldProjectList = app.ProjectManagementHelper.GetProjectList();

            app.ManagementMenuHelper.InitProject();

            string projectName= GenerateRandomString(5);
            ProjectData project1 = new ProjectData(projectName);
                

            app.ProjectManagementHelper.EnterName(projectName);
            app.ProjectManagementHelper.AddProject();

            List<ProjectData> newProjectList= app.API.ListApiProjetData(account);
          //List<ProjectData> newProjectList = app.ProjectManagementHelper.GetProjectList();

            oldProjectList.Add(project1);

            oldProjectList.Sort();
            newProjectList.Sort();
            Assert.AreEqual(oldProjectList, newProjectList); 

            app.ProjectManagementHelper.ExitMantis();
        }

      

       




    }
}
