using MarsProject.Automation_Task.Profile;
using MarsProject.Pages;
using MarsProject.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject.TestProfile
{
    public class SkillProfileTests : CommonServices
    {
         Profile_Skills ml;

        [OneTimeSetUp]
        public void Setup()
        {
            homePage hp = new homePage(driver);
            hp.homePageNavigate();
            hp.signin();
            LoginPage lgin = new LoginPage(driver);
            lgin.Login();

            ml = new Profile_Skills(driver);

        }


        /*  [Test , Order(1), Description("This will LoginThe Page ")]
          public void T002_LoginPage()
          {
              // T001_HomePage();
              LoginPage lgin = new LoginPage(driver);
              lgin.Login();

          }*/


        [Test, Order(2), Description("This will add skills record")]
        public void T003_AddSkills()
        {
            //T002_LoginPage();
            goToTab("Skills");
           
            ml.addSkills();

        }

        [Test, Order(3), Description("This will edit language record")]
        public void T004_EditSkills()
        {
            goToTab("Skills");

            ml.editSkill();
        }

        [OneTimeTearDown]
        public void CloseBrowser_Test()
        {
            driver.Quit();

        }
    }
}
