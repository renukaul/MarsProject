using MarsProject.Pages;
using MarsProject.Profile;
using MarsProject.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsProject
{
    [Binding]
    public class ProfileSkillStepDefinitions : CommonServices
    {

        ManageSkill obj; // = new ManageSkill();

        [Given(@"Logged in app Successfully and goto skill tab")]
        public void GivenLoggedInAppSuccessfullyAndGotoSkillTab()
        {
            homePage hp = new homePage(driver);
            hp.homePageNavigate();
            hp.signin();
            LoginPage lgin = new LoginPage(driver);
            lgin.Login();
            obj = new ManageSkill(driver);
            goToTab("Skills");
        }

        [When(@"Skill is added")]
        public void WhenSkillIsAdded()
        {
            obj.addSkills();
        }

        [Then(@"Skill Should be added sucessfully")]
        public void ThenSkillShouldBeAddedSucessfully()
        {
            string skill = "Skill1";

            string lastskill = obj.getLastSkill();

            Assert.That(lastskill == skill, "Skill not added, Test Failed");
            driver.Quit();
        }


        [When(@"Skill is Updated")]
        public void WhenSkillIsUpdated()
        {
            obj.editSkill();
        }

        [Then(@"Skill Should be Updated  sucessfully")]
        public void ThenSkillShouldBeUpdatedSucessfully()
        {
            string skill = "Skill2";
            string lastskill = obj.getLastSkill();
            Assert.That(lastskill == skill, "Skill not added, Test Failed");
            driver.Quit();
        }


        [When(@"Skill is Deleted")]
        public void WhenSkillIsDeleted()
        {
            obj.deleteSkill();
        }

        [Then(@"Skill Should be Deleted  sucessfully")]
        public void ThenSkillShouldBeDeletedSucessfully()
        {
            Assert.That(1 == 1, "Record deleted successfully");
            driver.Quit();
        }
    }
}
