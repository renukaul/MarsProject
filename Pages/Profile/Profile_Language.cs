using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;*/
using System.Threading;
//using System.Threading.Tasks;
//using TalentProfileProject.Utilities;

namespace TalentProfileProject.Profile
{
    public class ShareSkillTests

    {
        //POM for addlanguage
        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        IWebElement addNewBtn;
       

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        [CacheLookup]
        IWebElement txtBox;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        [CacheLookup]
        IWebElement dropDown;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        IWebElement dropDownSelect;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        IWebElement addBtn;

        //POM for editlanguage
        [FindsBy(How = How.XPath , Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")]
        IWebElement editBtn;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input")]
        IWebElement editedLangtxtbox;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select")]
        IWebElement lvlTextBox;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]")]
        IWebElement updateBtn;

        IWebDriver driver;

        //Delete Button
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")]
        IWebElement deleBtn;

        //GoTo Last Language
        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")]
        IWebElement lang;

        //Get Last Level
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")]
        IWebElement lvl;

        public ShareSkillTests(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        public void addLanguage()
        {
           //Add New Record
            addNewBtn.Click();
                      
            //Add Text in the Textbox
            txtBox.Click();
            txtBox.SendKeys("English");

           //Select from dropdown
            dropDown.Click();

            //Send Key here
            dropDownSelect.SendKeys("Conversational");
            dropDownSelect.Click();


            //Then click add button
            addBtn.Click();

            


        }
        public void editLanguage(string lang,string lvl)
        {

            //Click on pen element to make the row editable

            Thread.Sleep(4000);
           
            editBtn.Click();

            //This is textbox here
            editedLangtxtbox.Clear();
            editedLangtxtbox.SendKeys(lang);

            //Level Text box
            lvlTextBox.SendKeys(lvl);
            lvlTextBox.Click();

            Thread.Sleep(4000);

            //This is update button which will actually update
             updateBtn.Click();

            
        }

        public void deleteLanguage()
        {
            Thread.Sleep(2000);

            //Delete Button
            deleBtn.Click();
        }
       
       
        public string getLastLanguage()
        {
            Thread.Sleep(2000);
            //GoTo Last Language
             return lang.Text;

        }


        public string getLastLevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
           
            //Get Last Level
            return lvl.Text;

        }




    }
}
