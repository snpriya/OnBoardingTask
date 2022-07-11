using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class Certificate:CommonDriver
    {
        public void addCertificate(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10);
            //click on certification page
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
            //click add new
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();
            //add certificate
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("Test Analyst");
            //add institution
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")).SendKeys("Industry Connect");
            //select year from dropdown
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[7]")).Click();
            //click add button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();
            Thread.Sleep(1000);
        
        }

        public String checkAddCeritificate(IWebDriver driver)
        {
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]",5);
            Thread.Sleep(2000);
            IWebElement certi = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return certi.Text;
        
        }
        public String checkcertificate(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input", 4);
            Thread.Sleep(2000);
            IWebElement certifrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            return certifrom.Text;
        }
    
    
        public void updatecertificate(IWebDriver driver,String certificate)
        {
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[1]/div/a[2]", 2);
            //click on profiletab
            //driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
            //click on certificate page
             WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
            //click on edit button
            WaitHelpers.WaitToBeClickable(driver,"XPath","//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i", 6);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i")).Click();
            //enter the certificate name
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input", 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input")).Clear();
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input", 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input")).SendKeys(certificate);
            //click update button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        }
        public String checkupdatecertificate(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]",5);
            IWebElement newcerti = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return newcerti.Text;
           
        }
        public void deletecertificate(IWebDriver driver,String certificate)
        {
            try
            {
                WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[1]/div/a[2]", 2);
                //click on profiletab
                driver.FindElement(By.XPath("//div/section[1]/div/a[2]")).Click();
                //click on certificate page
                // WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10);
                driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
                driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
                //click deletebutton
                driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i")).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("not deleted");
            }
        }
        

    }
}
