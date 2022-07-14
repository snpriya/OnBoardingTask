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
    public class Education : CommonDriver
    {
        public void AddEducation(IWebDriver driver,String country,String university,String coursetitle,String degree,String year)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[1]/div/a[2]", 2);
            //click on profiletab
            driver.FindElement(By.XPath("//div/section[1]/div/a[2]")).Click();
            //click on education tab
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
            //click addnew button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();
            //enter universityor collegename
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")).SendKeys(university);
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select", 5);
            //select country from dropdown
            var coun = (driver.FindElement(By.Name("country")));
            var selectElement = new SelectElement(coun);
            selectElement.SelectByValue(country);
            Thread.Sleep(2000);
            //select the title from dropdown
            var degtitle = driver.FindElement(By.Name("title"));
            var selectElementnew = new SelectElement(degtitle);
            selectElementnew.SelectByValue(coursetitle);
            //enter degree
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys(degree);
            //enter year of graduation
            var gyear = (driver.FindElement(By.Name("yearOfGraduation")));
            var selectelement = new SelectElement(gyear);
            selectelement.SelectByValue(year);
            Thread.Sleep(1000);
            //click add button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 2);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();

        }
        public String checkdegree(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath","//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]", 2);
            IWebElement deg = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
            return deg.Text;
        }
        public String checktitlecourse(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath","//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]", 2);
            IWebElement title = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
            return title.Text;
        }
        public String checkuniversity(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath","//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 2);

            IWebElement univ = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return univ.Text;
        }
        public String checkyear(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath","//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]", 2);
            IWebElement gyear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]"));
            return gyear.Text;
        }
        public String checkcountry(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath","//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 2);
            
            IWebElement con =driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
             return con.Text;
        }

        public void UpdateEducation(IWebDriver driver, String country, String university, String coursetitle, String degree, String year)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]",5);
            //click on education tab
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
            //click on edit button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i", 2);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i")).Click();
            //edit coursetitle
            var editdegtitle = driver.FindElement(By.Name("title"));
            var selectElementedit = new SelectElement(editdegtitle);
            selectElementedit.SelectByValue(coursetitle);
            Thread.Sleep(2000);
            //edit university
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[1]/input")).Clear();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[1]/input", 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[1]/input")).SendKeys(university);
            //edit the degree
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input")).Clear();
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input")).SendKeys(degree);
            //edit country
            Thread.Sleep(1000);
            var cou = driver.FindElement(By.Name("country"));
            var selectelement = new SelectElement(cou);
            selectelement.SelectByValue(country);
            Thread.Sleep(1000);
            //edit year
            Thread.Sleep(1000);
            var gyear = driver.FindElement(By.Name("yearOfGraduation"));
            var selectElement1 = new SelectElement(gyear);
           selectElement1.SelectByValue(year);
            //click update button
            //Thread.Sleep(1000);
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[3]/input[1]", 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[3]/input[1]")).Click();
            
        }
        
        public string checkeditdegree(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]", 2);
            IWebElement editdegree=driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
            return editdegree.Text; 
        }
        public String checkedityear(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]", 2);
            IWebElement edityear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]"));
            return edityear.Text;
        }
        public String checkeditcountry(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 2);
            IWebElement editcountry = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editcountry.Text;
        }
        
        public void DeleteEducation(IWebDriver driver,String degree)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 4);
            //click on educationtab
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
            Thread.Sleep(1000);
            try
            {
                WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i", 5);
                //click delete button
                driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i")).Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("not Deleted successfully");
            }

       }
        


    }
}
        
    

