using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TalentShareSkillProject.Utilities;

namespace MarsProject.Automation_Task.ShareSkill
{
   public class ShareSkill
    {
        IWebDriver driver;

        //Add Button
        [FindsBy(How = How.XPath, Using = "//div/section[1]/div/div[2]/a")]
        IWebElement AddButton;
       
       


        // Title = driver.FindElement(By.XPath("//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        IWebElement Title;



        //Description = driver.FindElement(By.XPath("//div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        IWebElement Description;

        //Category = driver.FindElement(By.XPath("//div[2]/div/form/div[3]/div[2]/div/div/select"));
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[3]/div[2]/div/div/select")]
        IWebElement Category;

        //SubCategory
        [FindsBy(How = How.XPath, Using = "//div/form/div[3]/div[2]/div/div[2]/div[1]/select")]
        IWebElement SubCategory;

        //ServiceTag = driver.FindElement(By.XPath("//div/form/div[4]/div[2]/div/div/div/div/input"));
        [FindsBy(How = How.XPath, Using = "//div/form/div[4]/div[2]/div/div/div/div/input")]
        IWebElement ServiceTag;

        //ServiceTpe
        [FindsBy(How = How.Name, Using = "serviceType")]
        IList<IWebElement> ServiceType;

        //LocationType
        [FindsBy(How = How.Name, Using = "locationType")]
        IList<IWebElement> LocationType;

        //StartDate = driver.FindElement(By.XPath("//div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]
        IWebElement StartDate;


        //EndDate = driver.FindElement(By.XPath("//div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]
        IWebElement EndDate;
        
        //SkillTrade
        [FindsBy(How = How.Name, Using = "skillTrades")]
        IList<IWebElement> SkillTrade;

        //SkillExchange
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        IWebElement SkillExchangeTag;

        //WorkSample
        [FindsBy(How = How.XPath, Using = "////div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        IWebElement WrkSample;

        //Active 
        [FindsBy(How = How.Name, Using = "isActive")]
        IList<IWebElement> Active;

        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[11]/div/input[1]")]
        IWebElement SaveBtn;

        

        //Title TextBox
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        IWebElement titletxtbox;

        //Description Text Area
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        IWebElement DescTxtArea;

        //Save Button
        [FindsBy(How = How.XPath, Using ="//div[2]/div/form/div[11]/div/input[1]")]
        IWebElement saveBtn;


        public ShareSkill(IWebDriver _driver)
        {
            driver = _driver;
        
            PageFactory.InitElements(driver, this);
        }


        public void addShareSkill()

        {
            // Thread.Sleep(2000);
            
            wait.waitByClick(driver, "xPath", AddButton, 2);

            AddButton.Click();
            Title.Click();
            Title.SendKeys("Programming Tech");

            Description.Click();
            Description.SendKeys("Test Analyst Role");

            Category.Click();
            Category.SendKeys("Graphics & Design");

            ServiceTag.Click();
            ServiceTag.SendKeys("Test Engineer");
            ServiceTag.SendKeys(Keys.Enter);

            ServiceType.ToList();
            ServiceType[0].Click();

            /* ServiceTag.Click();
             ServiceTag.SendKeys("Test Engineer 1");
            */
              LocationType.ToList();
              LocationType[0].Click();


            //Start and End Date
            StartDate.Click();
            StartDate.SendKeys("04/17/2023");

            EndDate.Click();
            EndDate.SendKeys("04/27/2023");

            SkillTrade.ToList();
            SkillTrade[0].Click();

           // Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", SkillExchangeTag, 2);
            SkillExchangeTag.Click();
            SkillExchangeTag.SendKeys("Test Engineer & Desgning 1");
            SkillExchangeTag.SendKeys(Keys.Enter);

            Active.ToList();
            Active[0].Click();  

            SubCategory.Click();
            SubCategory.SendKeys("Logo Design");

            SaveBtn.Click();


        }
        

        public void editShareSkill()
        {
            //ManageListing
            //Thread.Sleep(2000);

            wait.waittovisibility(driver, "xPath", "//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input", 2);

            titletxtbox.Click();
            titletxtbox.Clear();
            titletxtbox.SendKeys("Application Technology");
                                    
            DescTxtArea.Click();
            DescTxtArea.Clear();
            DescTxtArea.SendKeys("Application Technology Role");

            saveBtn.Click();

        }






    }
}
