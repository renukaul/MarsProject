using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;*/
using System.Threading;
using TalentShareSkillProject.Utilities;
//using System.Threading.Tasks;
//using TalentProfileProject.Utilities;

namespace TalentProfileProject.Profile
{
    public class ManageLanguage

    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        IWebElement addNewBtn;

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        IWebElement txtBox;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        IWebElement dropDown;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        IWebElement dropDownSelect;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        IWebElement addBtn;


        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")]
        IWebElement editBtn;


        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input")]
        IWebElement editedLangtxtbox;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select")]
        IWebElement lvlTextBox;


        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]")]
        IWebElement updateBtn;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")]
        IWebElement deleBtn;

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")]
        IWebElement lang;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")]
        IWebElement lvl;

        public ManageLanguage(IWebDriver _driver)
        {
            driver = _driver;

            PageFactory.InitElements(driver, this);
        }

        public ManageLanguage()
        {
        }

        public void addLanguage()
        {
           /* Thread.Sleep(2000);
             IWebElement language = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            // IWebElement language = driver.FindElement(By.CssSelector("th[textContent='Languages']"));
            language.Click();*/


           
            addNewBtn.Click();
                        
            txtBox.Click();
            txtBox.SendKeys("English");
                      
            dropDown.Click();

            
            dropDownSelect.SendKeys("Conversational");
            dropDownSelect.Click();


           
            addBtn.Click();



        }
        public void editLanguage(IWebDriver driver,string lang,string lvl)
        {

            //Click on pen element to make the row editable

            // Thread.Sleep(4000);
            // IWebElement editBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]//child::i[@class='outline write icon']"));
            wait.waitByClick(driver, "xPath", editBtn, 2);
            editBtn.Click();

            //This is textbox here
            editedLangtxtbox.Clear();
            editedLangtxtbox.SendKeys(lang);

            //Level Text box
            lvlTextBox.SendKeys(lvl);
            lvlTextBox.Click();

            //Thread.Sleep(4000);

            //This is update button which will actually update
            wait.waitByClick(driver, "xPath", updateBtn, 2);
            updateBtn.Click();

            
        }

        public void deleteLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", deleBtn, 2);
            deleBtn.Click();
        }
       
       
        public string getLastLanguage()
        {
            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", lang, 2);
            return lang.Text;

        }


        public string getLastLevel()
        {
            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", lvl, 2);
            return lvl.Text;

        }




    }
}
