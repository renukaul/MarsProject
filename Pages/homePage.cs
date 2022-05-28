using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;


namespace MarsProject.Pages
{
    public class homePage
    {
        IWebDriver driver;


        [FindsBy(How = How.XPath, Using = "//div/div/div[1]/div/a")]
        IWebElement signInbtn;

        

        public homePage(IWebDriver _driver)
        {
            driver = _driver;
            
            PageFactory.InitElements(driver,this);
        }

        public void homePageNavigate()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
        }

        public void signin()
        {
            signInbtn.Click();
        }

       

    }
}
