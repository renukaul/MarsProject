using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsProject.Pages.Manage_Listing
{
    public class ManageListing
    {
        IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")]
        IWebElement Category;

        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")]
        IWebElement Title;

        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]")]
        IWebElement Description;

        //Click ManageListing
        [FindsBy(How = How.XPath, Using = "//section[1]/div/a[3]")]
        IWebElement managelisting;

        //Edit Share Skill Button
        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i")]
        IWebElement editBtn;

        public ManageListing(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver,this);
        }
        public string getCategory()
        {
            Thread.Sleep(2000);
            string cat = Category.Text;
            return cat;

        }

        public void clickEditButton()
        {
            Thread.Sleep(2000);
            managelisting.Click();

            Thread.Sleep(2000);
            editBtn.Click();
        }

        public string getTitle()
        {
            Thread.Sleep(2000);
            return Title.Text;

        }

        public string getDescription()
        {
            Thread.Sleep(2000);
            return Description.Text;

        }

        public void DeleteRecord()
        { 
        }

    }
   

}

