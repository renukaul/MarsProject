using MarsProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsProject.Utilities
{
    public class CommonServices
    {
       
        public IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")]
        IWebElement languagetab;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")]
        IWebElement skilltab;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")]
        IWebElement educationtab;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")]
        IWebElement certificatetab;

        public CommonServices() //IWebDriver _driver)
        {
            driver = new ChromeDriver();
            PageFactory.InitElements(driver, this);

        }


       
        

        public void goToTab(string tabName)
        {
            
            Thread.Sleep(2000);
            switch (tabName)
            {
                case "Languages":
                    languagetab.Click();
                    break;
                case "Skills":
                    skilltab.Click();
                    break;
                case "Education":
                   educationtab.Click();
                    break;
                case "Certifications":
                    certificatetab.Click();
                    break;


            }



        }
       
        
    }
}
