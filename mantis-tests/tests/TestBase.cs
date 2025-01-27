﻿using System;
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

        //[TearDown]
        //public void TeardownTest()
        //{
        //    try
        //    {
        //        driver.Quit();
        //    }
        //    catch (Exception)
        //    {
        //        // Ignore errors if unable to close the browser
        //    }
        //    Assert.AreEqual("", verificationErrors.ToString());
        //}



    


      



    }
}
