using MarsProject.Automation_Task.ShareSkill;
using MarsProject.Pages;
using MarsProject.Pages.Manage_Listing;
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
    public class ShareSkillTests : CommonServices
    {

        ShareSkill sk_object;
        ManageListing ml;

        [OneTimeSetUp]
        public void Setup()
        {
                 homePage hp = new homePage(driver);
                 hp.homePageNavigate();
                 hp.signin();
                 LoginPage lgin = new LoginPage(driver);
                 lgin.Login();

            sk_object = new ShareSkill(driver);
            ml = new ManageListing(driver);

        }




        [Test, Order(2), Description("This will add language record")]
        public void T003_AddShareSkill()
        {
            sk_object.addShareSkill();

            string categoryLastAdded = ml.getCategory();

            string categoryAdded = "Graphics & Design";

            Assert.That(categoryAdded == categoryLastAdded, "test Failed");

        }

        [Test, Order(3), Description("This will edit ShareSkill record")]
        public void T004_EditShareSkill()
        {
            ml.clickEditButton();
            sk_object.editShareSkill();

            string editedTitle = "Application Technology";
            string editedDescription = "Application Technology Role";

            Assert.That(editedTitle == ml.getTitle(), "Test Fail");
            Assert.That(editedDescription == ml.getDescription(), "Test Fail");




        }

        [Test, Order(4), Description("This will delete ShareSkill Record")]
        public void T005_DeleteShareSkill()
        {
           


        }



        [OneTimeTearDown]
        public void CloseBrowser_Test()
        {
           driver.Quit();

        }

    }
}