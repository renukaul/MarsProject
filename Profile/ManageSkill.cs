using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TalentShareSkillProject.Utilities;

namespace MarsProject.Profile
{
    public class ManageSkill
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        IWebElement addSkill;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")]
        IWebElement txtBox;

        
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")]
        IWebElement dropDown; 
            

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")]
        IWebElement skillLevel;

        
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")]
        IWebElement addSkillBtn;
            
        
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")]
        IWebElement lastSkill;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")]
        IWebElement editSkillbtn;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")]
        IWebElement txtBoxEdit;
        

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        IWebElement updatebtn;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")]
        IWebElement delBtn;

        
        public ManageSkill(IWebDriver _driver)
        {
            driver = _driver;

            PageFactory.InitElements(driver, this);
        }

       
        public void addSkills()
        {
            /*Thread.Sleep(2000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();*/

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", addSkill, 2);
            addSkill.Click();

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtBox, 2);
            txtBox.Click();
            txtBox.SendKeys("Skill1");


            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", addSkill, 2);
            dropDown.Click();

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", addSkill, 2);
            skillLevel.SendKeys("Beginner");
            skillLevel.Click();

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", addSkill, 2);
            addSkillBtn.Click();

        }


        public string getLastSkill()
        {

            Thread.Sleep(2000);
            //wait.waitByClick(driver, "xPath", lastSkill, 2);

            return lastSkill.Text;

        }


        public void editSkill()
        {
            /*Thread.Sleep(2000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();*/

           
            editSkillbtn.Click();

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", txtBoxEdit, 2);
            txtBoxEdit.Clear();
            txtBoxEdit.Click();

            //Thread.Sleep(2000);
            txtBoxEdit.SendKeys("Skill2");

            
            updatebtn.Click();

        }

       public void deleteSkill()
        {

            /*Thread.Sleep(2000);

            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();*/

            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", addSkill, 2);
            delBtn.Click();

            /*IAlert al = driver.SwitchTo().Alert();
            al.Accept();
*/
            /*IWebElement confirmDel = driver.FindElement(By.XPath("//div[2]/div/div[3]/button[2]"));
            confirmDel.Click();*/
        }


    }
}
