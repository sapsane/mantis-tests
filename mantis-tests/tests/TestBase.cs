using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace mantis_tests
{
    public class TestBase
    {
        public static bool PERFORM_LONG_UI_CHECKS = true;
        protected ApplicationManager app;

        [OneTimeSetUp]
        public void SetupApplicationManager()
        {
            app = ApplicationManager.GetInstance();
           

        }

        //[OneTimeTearDown]
        //public void StopApplicationManager()
        //{
        //    ApplicationManager.GetInstance().Stop();

        //}


        public static Random rnd = new Random();

        public static string GenerateRandomString(int max)
        {
            
            int l = Convert.ToInt32(rnd.NextDouble() * max);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < l; i++) 
            {
                builder.Append( Convert.ToChar(32+ Convert.ToInt32(rnd.NextDouble()*65)));
            }
            return builder.ToString();
        }

        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        //[SetUp]
        //public void SetupTest()
        //{
        //    driver = new FirefoxDriver();
        //    baseURL = "http://localhost/mantisbt-2.26.4/";
        //    verificationErrors = new StringBuilder();
        //}

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }


        public void InitProject()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        public void ExitMantis()
        {
            driver.FindElement(By.XPath("//div[@id='navbar-container']/div[2]/ul/li[3]/a/span")).Click();
            driver.FindElement(By.LinkText("Выход")).Click();
        }

        public void AddProject()
        {
            driver.FindElement(By.XPath("//input[@value='Добавить проект']")).Click();
        }

        public void EnterName()
        {
            driver.FindElement(By.Id("project-name")).Click();
            driver.FindElement(By.Id("project-name")).Clear();
            driver.FindElement(By.Id("project-name")).SendKeys("test18");
        }

        public void ProjectsTab()
        {
            driver.FindElement(By.LinkText("Проекты")).Click();
        }

        public void Control()
        {
            driver.FindElement(By.CssSelector("i.fa.fa-gears.menu-icon")).Click();
        }



    }
}
