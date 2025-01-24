using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mantis_tests.Mantis;
using OpenQA.Selenium;

namespace mantis_tests
{
    public class ApiHelper : HelperBase
    {
        public ApiHelper(ApplicationManager manager) : base(manager)
        {
        }

        public List<ProjectData> ListApiProjetData(AccountData account)
        {
            Mantis.MantisConnectPortTypeClient client = new Mantis.MantisConnectPortTypeClient();
            

            List<ProjectData> project1List = new List<ProjectData>();
            client.mc_projects_get_user_accessible(account.AccountName, account.Password);

          
            foreach (var i in client.mc_projects_get_user_accessible(account.AccountName, account.Password))
            {
                String nameProject2 = i.name;
                ProjectData project2 = new ProjectData(nameProject2);
                project1List.Add(project2);
            }

            return project1List;

        }

        public void CreateApiProjet(AccountData account)
        {
            Mantis.MantisConnectPortTypeClient client = new Mantis.MantisConnectPortTypeClient();
                        
            Mantis.ProjectData project3 = new Mantis.ProjectData
            { name = "Test99" };

            client.mc_project_add(account.AccountName, account.Password, project3);
        }
    }
}
