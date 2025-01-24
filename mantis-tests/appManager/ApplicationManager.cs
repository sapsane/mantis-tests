using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using OpenQA.Selenium.Firefox;



namespace mantis_tests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;

       
        private static ThreadLocal<ApplicationManager> app=new ThreadLocal<ApplicationManager>();
        protected LoginHelper loginHelper;
        protected ProjectManagementHelper projectManagementHelper;
        protected ManagementMenuHelper managementMenuHelper;

       

        


        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/mantisbt-2.26.4/";
            // verificationErrors = new StringBuilder();
            loginHelper = new LoginHelper(this);
            projectManagementHelper = new ProjectManagementHelper(this);
            managementMenuHelper = new ManagementMenuHelper(this);
            API = new ApiHelper(this);

        }

        ~ApplicationManager() 
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }


        public static ApplicationManager GetInstance() 
        {
            if (! app.IsValueCreated ) 
            {
                ApplicationManager newInstance = new ApplicationManager();
             //   newInstance.Navigator.OpenHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }

        public IWebDriver Driver 
        {
            get 
            {
                return driver;  
            }
          
        }
        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public ProjectManagementHelper ProjectManagementHelper
        {
            get
            {
                return projectManagementHelper;
            }
        }
        public ManagementMenuHelper ManagementMenuHelper
        {
            get
            {
                return managementMenuHelper;
            }
        }


        public ApiHelper API { get; set; }





        public void Stop() 
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                //ignore errors
            }
        }





    }







}
