using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace mantis_tests
{
    public  class LoginHelper: HelperBase
    {

        public LoginHelper(ApplicationManager manager) : base(manager)
        {

        }

        public void Login()
        {
            driver.Navigate().GoToUrl("http://localhost/mantisbt-2.26.4/login_page.php");
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("administrator");
            driver.FindElement(By.XPath("//input[@value='Вход']")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("root");
            driver.FindElement(By.XPath("//input[@value='Вход']")).Click();
        }
        



    }
}
