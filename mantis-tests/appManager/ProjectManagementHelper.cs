using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace mantis_tests
{
    public class ProjectManagementHelper : HelperBase
    {

        public ProjectManagementHelper(ApplicationManager manager) : base(manager)
        {

        }

        public void EnterName()
        {
            driver.FindElement(By.Id("project-name")).Click();
            driver.FindElement(By.Id("project-name")).Clear();
            driver.FindElement(By.Id("project-name")).SendKeys("test20");
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






    }
}
