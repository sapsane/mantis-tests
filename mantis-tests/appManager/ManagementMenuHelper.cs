using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace mantis_tests
{
    public class ManagementMenuHelper : HelperBase
    {
        public ManagementMenuHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void Control()
        {
            driver.FindElement(By.CssSelector("i.fa.fa-gears.menu-icon")).Click();
        }


        public void ProjectsTab()
        {
            driver.FindElement(By.LinkText("Проекты")).Click();
        }



        public void InitProject()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }


    }
}
