using MarsProject.Pages;
using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using TalentProfileProject.Profile;

namespace MarsProject.TestProfile
{
    public class LanguageProfileTests : CommonServices
    {

        TalentProfileProject.Profile.ShareSkillTests ml;

        [OneTimeSetUp]
        public void Setup()
        {
                 homePage hp = new homePage(driver);
                 hp.homePageNavigate();
                 hp.signin();
                 LoginPage lgin = new LoginPage(driver);
                 lgin.Login();

            ml = new TalentProfileProject.Profile.ShareSkillTests(driver);

        }


      /*  [Test , Order(1), Description("This will LoginThe Page ")]
        public void T002_LoginPage()
        {
            // T001_HomePage();
            LoginPage lgin = new LoginPage(driver);
            lgin.Login();

        }*/


        [Test, Order(2), Description("This will add language record")]
        public void T003_AddLanguage()
        {
            //T002_LoginPage();
            goToTab("Languages");
            ml.addLanguage();

            string langAdded = ml.getLastLanguage();
            Assert.That(langAdded == "English", "Not able to add language , Test Failed");

        }

        [Test, Order(3), Description("This will edit language record")]
        public void T004_EditLanguage()
        {
           goToTab("Languages");
           ml.editLanguage("Spanish","Beginner");
            string Languageedited = ml.getLastLanguage();
            Assert.That(Languageedited == "Spanish", "Not able to edit language", "Test Failed");

        }

        [Test, Order(4), Description("This will delete language record")]
        public void T005_DeleteLanguage()
        {
            goToTab("Languages");
            ml.deleteLanguage(); 


        }



        [OneTimeTearDown]
        public void CloseBrowser_Test()
        {
            driver.Quit();

        }

    }
}