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

        public void EnterName(string name)
        {
            driver.FindElement(By.Id("project-name")).Click();
            driver.FindElement(By.Id("project-name")).Clear();
            driver.FindElement(By.Id("project-name")).SendKeys(name);
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

        public void SelectProject()
        {
            driver.FindElement(By.XPath("//tr[1]/td/a")).Click();
            //driver.FindElement(By.XPath("//div[@id='main-container']/div[2]/div[2]/div/div/div[2]/div[2]/div/div[2]/table/tbody/tr/td/a")).Click();
        }

        public void DeleteProject()
        {
            driver.FindElement(By.XPath("//form[@id='manage-proj-update-form']/div/div[3]/button[2]")).Click();
        }

        public void CommitDeleteProject()
        {
            driver.FindElement(By.XPath("//input[@value='Удалить проект']")).Click();
        }



        public List<ProjectData> GetProjectList()
        {
            manager.ManagementMenuHelper.Control();
            manager.ManagementMenuHelper.ProjectsTab();
            List <ProjectData> project1 = new List<ProjectData>();
            
           
            ICollection<IWebElement> row = driver.FindElements(By.XPath("//tr/td/a"));

            foreach (IWebElement row2 in row)
            {
               string nameProject= row2.Text;
               
                ProjectData project2 = new ProjectData(nameProject);
                project1.Add(project2);    
              
            }       
            return  project1;
        }
    }
}
