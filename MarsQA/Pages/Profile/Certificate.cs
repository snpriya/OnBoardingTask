using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace MarsQA.Pages.Profile
{
    public class Certificate 

    {
        public IWebDriver driver;
        Certificate certificateobj;

        //Form constructor 1
        public Certificate(IWebDriver driver)
        {
            //initial driver object
            this.driver = driver;
        }
        public void addCertificate(IWebDriver driver, string certificate, string from, string year)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10);
            //click on certification page
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
            //click add new
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();
            //add certificate
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys(certificate);
            //add institution
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")).SendKeys(from);
            //select year from dropdown
            var certiyear = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            certiyear.SelectByValue(year);

            //click add button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();
            Thread.Sleep(1000);

        }

        public string checkCeritificate(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 5);
            Thread.Sleep(2000);
            IWebElement certi = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return certi.Text;

        }
        public string checkcertificatefrom(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]", 4);
            Thread.Sleep(2000);
            IWebElement certifrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return certifrom.Text;
        }
        public string checkcertificateyear(IWebDriver driver)
        {
            IWebElement certiyear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
            return certiyear.Text;
        }


        public void updatecertificate(IWebDriver driver, string certificate, string from, string year)
        {
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[1]/div/a[2]", 2);
            //click on profiletab
            //driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
            //click on certificate page
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
            //click on edit button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i", 6);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i")).Click();
            //enter the certificate name
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[1]/input", 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[1]/input")).Clear();
            //WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[1]/input", 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[1]/input")).SendKeys(certificate);
            //enter certificate from
            //clear certificatefrom
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[2]/input")).Clear();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input", 5);
            //enter certificatefrom
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[2]/input")).SendKeys(from);
            //enter year
            var certiyear = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            certiyear.SelectByValue(year);
            //click update button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table[last()]/tbody/tr/td/div/span/input[1]")).Click();
            Thread.Sleep(1000);
        }
        
        public void deletecertificate(IWebDriver driver, string certificate)
        {
            try
            {


                WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[1]/div/a[2]", 2);
                //click on profiletab
                driver.FindElement(By.XPath("//div/section[1]/div/a[2]")).Click();
                //click on certificate page
                 WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
                driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
                Thread.Sleep(1000);
                
                driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
                //click deletebutton
                driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i")).Click();

                Thread.Sleep(1000);

            }
            catch (Exception ex)
            {
                Assert.Fail("not deleted");
            }
        }
        public string delcertificate(IWebDriver driver)
        {
            IWebElement del = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Thread.Sleep(1000);
            return del.Text;
            
        }


    }
}
