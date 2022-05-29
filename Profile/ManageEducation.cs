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
   public class ManageEducation
    {

        [FindsBy(How = How.XPath , Using = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")]
        IWebElement addbtn;


        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")]
        IWebElement txtbox;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")]
        IWebElement dropdownplace; 

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")]
        IWebElement dropDownTitle;
            
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")]
        IWebElement txtboxdegree;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")]
        IWebElement dropDownYear;
  

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")]
        IWebElement addBtn;


        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i")]
        IWebElement editbtn;


        [FindsBy(How = How.XPath, Using = "div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input")]
        IWebElement txtboxUni;


        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")]
        IWebElement updBtn;

        
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i")]
        IWebElement delEducation;


        public void addEducation(IWebDriver driver)
        {
            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", addbtn, 2);
            addbtn.Click();

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtbox, 2);
            txtbox.Click();
            txtbox.SendKeys("Victoria Uni");


            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", dropdownplace, 2);
            dropdownplace.Click();
            dropdownplace.SendKeys("Austria");

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtbox, 2);
            
            dropDownTitle.Click();
            dropDownTitle.SendKeys("PHD");

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtbox, 2);
            txtboxdegree.Click();
            txtboxdegree.SendKeys("degree");


            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtbox, 2);
            dropDownYear.Click();
            dropDownYear.SendKeys("2013");


            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtbox, 2);
            addBtn.Click();

       }


        public string getlastCountry(IWebDriver driver)
        {
            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtbox, 2);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;

        }


        public string getlastUniv(IWebDriver driver)
        {
            // Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtbox, 2);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;

        }


        public void editEducation(IWebDriver driver)
        {
            //Thread.Sleep(2000
            wait.waitByClick(driver, "xPath", editbtn, 2);
            editbtn.Click();


            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtboxUni, 2);
            txtboxUni.Click();
            txtboxUni.Clear();
            txtboxUni.SendKeys("Auck Univ");

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", updBtn, 2);
            updBtn.Click();


        }
        public void deleteEducation(IWebDriver driver)
        {
            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", delEducation, 2);
            delEducation.Click();

        }


    }
}
