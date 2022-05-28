using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TalentProfileProject.Utilities;
using TechTalk.SpecFlow;

namespace TalentProfileProject
{
    [Binding]
    public class LoginStepDefinitions : Helping
    {
        [Given(@"user is in talent application and user is on login page")]
        public void GivenUserIsInTalentApplicationAndUserIsOnLoginPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
        }

        [When(@"user enters a valid '([^']*)' and '([^']*)'")]
        public void WhenUserEntersAValidAnd(string p0, string p1)
        {
            HelpLogin(p0, p1);


        }

        [Then(@"user should login  successfully")]
        public void ThenUserShouldLoginSuccessfully()
        {
            string welcomeMsg = getWelcomeMessage(driver);
            Assert.That(welcomeMsg.Contains("Hi"), "test pass");
            


        }
    }
}
