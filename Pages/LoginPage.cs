
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject.Pages
{
    public class LoginPage
    {

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div/div[1]/div/div[1]/input")]
        IWebElement UserName;

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div/div[1]/div/div[2]/input")]
        IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div/div[1]/div/div[4]/button")]
        IWebElement Loginbtn;

        IWebDriver driver;


        public LoginPage(IWebDriver _driver)
        {
            if (driver == null) { 
                driver = _driver;
               PageFactory.InitElements(driver, this);
            }
        }

        public void Login()
        {
            UserName.SendKeys("renukaul955@gmail.com");
            Password.SendKeys("target@123");
            Loginbtn.Click();

        }

    }
}
