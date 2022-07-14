using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class Language:CommonDriver
    {
        public void addLanguage(IWebDriver driver,String language,String languagelevel)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 6);
            //click language tab
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
            //click addnew button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            //add lanuage
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys(language);
            //select level
            var lanlevel = (driver.FindElement(By.Name("level")));
            var selectElement = new SelectElement(lanlevel);
            selectElement.SelectByValue(languagelevel);
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 5);
            //click add button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
        }
        public String checkaddlanguage(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 6);
            //check the added language
            IWebElement lan = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return lan.Text;
        }
        public String checkaddlanguagelevel(IWebDriver driver)
            {
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 3);
            IWebElement level = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return level.Text;


        }
        public void EditLanguage(IWebDriver driver,String language,String languagelevel)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 6);
            //click language tab
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
            //click addnew button
            //click on edit button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")).Click();
            //update language

            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Clear();
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input", 2);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).SendKeys(language) ;
            var lanlevel = (driver.FindElement(By.Name("level")));
            var selectElement = new SelectElement(lanlevel);
            selectElement.SelectByValue(languagelevel);
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]", 2);
            //click update button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
            Thread.Sleep(1000);
        }
        public String checkeditlanguage(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 6);
            IWebElement elan=driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return elan.Text;
            
        }
       
        public String checkeditlanguagelevel(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 3);
            Thread.Sleep(2000);
            IWebElement editlevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editlevel.Text;
        }
        public void DeleteLanguage(IWebDriver driver,String language)
        {
            try
            {
                //click delete button
                WaitHelpers.WaitToBeClickable(driver, "Xpath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 4);
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("not deleted successfully");

            }
        }
        
        
    }
}
