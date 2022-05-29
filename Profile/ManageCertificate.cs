using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TalentShareSkillProject.Utilities;

namespace TalentProfileProject.Profile
{
    public class ManageCertificate
    {
        IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")]
        IWebElement addCertificate;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")]
        IWebElement txtBox;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")]
        IWebElement certFrom;


        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")]
        IWebElement dropDown;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]")]
        IWebElement certYear;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")]
        IWebElement addCertBtn;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]")]
        IWebElement lastCertificate;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i")]
        IWebElement editSkillbtn;

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input")]
        IWebElement txtBoxEdit;  

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        IWebElement updatebtn;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i")]
        IWebElement delBtn;




        public ManageCertificate(IWebDriver _driver)
        {
            driver = _driver;

            PageFactory.InitElements(driver, this);
        }

        public ManageCertificate()
        {
        }

        public void addCertificates()
        {
            
            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", addCertificate, 2);
            addCertificate.Click();

            // Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtBox, 2);
            txtBox.Click();
            txtBox.SendKeys("TESTANALYST");

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", certFrom, 2);
            certFrom.Click();
            certFrom.SendKeys("INDUSTRYCONNECT");


           // Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", dropDown, 2);
            dropDown.Click();

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", certYear, 2);
            certYear.Click();

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", addCertBtn, 2);
            addCertBtn.Click();

        }


        public string getLastCertificate()
        {

           // Thread.Sleep(2000);
            wait.waittovisibility(driver, "xPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 2);
            return lastCertificate.Text;

        }


        public void editCertificate()
        {
            /*Thread.Sleep(2000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();*/

            
            editSkillbtn.Click();

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtBox, 2);
            
            txtBoxEdit.Clear();
            txtBoxEdit.Click();
            txtBoxEdit.SendKeys("ISTQB");

            
            updatebtn.Click();

        }

       public void deleteCertificate()
        {

            /*Thread.Sleep(2000);

            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();*/

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", delBtn, 2);
            delBtn.Click(); 


        }


    }
}
