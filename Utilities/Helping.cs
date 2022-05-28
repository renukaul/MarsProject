using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TalentProfileProject.Utilities
{
    public class Helping
    {
        public static IWebDriver driver;
        public void HelpLogin(string Uname, string password)
        {

            /*  driver.Manage().Window.Maximize();*/
            IWebElement signin = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signin.Click();

            IWebElement emailid = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailid.Click();
            emailid.SendKeys(Uname);



            IWebElement pwd = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            pwd.Click();
            pwd.SendKeys(password);


            IWebElement login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            login.Click();



        }


        public string getWelcomeMessage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement welcomeMsg = driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span"));
            return welcomeMsg.Text;
        }


    }
}
