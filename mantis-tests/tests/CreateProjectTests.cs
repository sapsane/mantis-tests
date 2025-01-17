using System;
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
        //private IWebDriver driver;
        //private StringBuilder verificationErrors;
        //private string baseURL;
        //private bool acceptNextAlert = true;

        //[SetUp]
        //public void SetupTest()
        //{
        //    driver = new FirefoxDriver();
        //    baseURL = "http://localhost/mantisbt-2.26.4/";
        //    verificationErrors = new StringBuilder();
        //}

        //[TearDown]
        //public void TeardownTest()
        //{
        //    try
        //    {
        //        driver.Quit();
        //    }
        //    catch (Exception)
        //    {
        //       // Ignore errors if unable to close the browser
        //   }
        //   Assert.AreEqual("", verificationErrors.ToString());
        //   }

        [Test]
        public void CreateProjectTest1()
        {
            app.Auth.Login();
            app.ManagementMenuHelper.Control();
            app.ManagementMenuHelper.ProjectsTab();
            app.ManagementMenuHelper.InitProject();

            app.ProjectManagementHelper.EnterName(GenerateRandomString(5));
            app.ProjectManagementHelper.AddProject();   
            app.ProjectManagementHelper.ExitMantis();
        }

      

       




    }
}
