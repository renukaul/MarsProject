using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsProject.Automation_Task.Profile
{
    public class Profile_Skills
    {
        //For Add skill button
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        IWebElement addSkill;

        //For TextBox
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")]
        IWebElement AddSkillTxtBox;

        //Dropdown 
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")]
        IWebElement dropDown;

        //SkillLevel element
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")]
         IWebElement skillLevel;

        //add skill button
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")]
        IWebElement addSkillBtn;

        //Last Skill
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")]
        IWebElement lastSkill;

        
        //Edit Share Skill button
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")]
        IWebElement editSkillbtn;

        //Last Text box
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")]
        IWebElement EditSkillTxtBox;


        //Add Button
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        IWebElement updatebtn;

         IWebDriver driver;

        public Profile_Skills(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        public void addSkills()
        {

           //Add skill button
            addSkill.Click();

           //TextBox text
            AddSkillTxtBox.SendKeys("Skill1");


            //Dropdown click
            dropDown.Click();

            //skill level
            skillLevel.SendKeys("Beginner");
            skillLevel.Click();

            //Add Skill Button
            addSkillBtn.Click();

        }

        public string getLastSkill(IWebDriver driver)
        {
            //Last Skill
            return lastSkill.Text;

        }
        public void editSkill()
        {
            /*Thread.Sleep(2000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();*/
            //Share Skill Button
            editSkillbtn.Click();


            EditSkillTxtBox.Clear();
            EditSkillTxtBox.Click();

            //Edit last share skill
            Thread.Sleep(2000);
            EditSkillTxtBox.SendKeys("Skill2");

            //add share skill
            updatebtn.Click();

        }






    }
}
