using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using MarsQA.Utilities;

namespace MarsQA.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;
        LoginPage LoginPageObj;
        public LoginPage(IWebDriver driver)
        {
            //initial driver object
            this.driver = driver;
        }

        public void LoginSteps(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            //enter the project url
            driver.Navigate().GoToUrl("http://localhost:5000/");
            //Thread.Sleep(5000);

            WaitHelpers.WaitToBeClickable(driver, "XPath","//*[@id='home']/div/div/div[1]/div/a", 2);
            try
            {
                //identify sign button
                IWebElement signinButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                signinButton.Click();
                //Thread.Sleep(1000);
                //identify the username textbox
                //enter the username
                IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                usernameTextbox.SendKeys("sathyanaganathan@gmail.com");
                //Thread.Sleep(1000);
                //identify the password textbox
                //enter password
                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys("Laksha17@");
                //Thread.Sleep(1000);
                //click login button
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
                
            }
                                  
            catch (Exception ex)
            {
              Assert.Fail("MarsQA portal not able to Launch");
            }
        }
    }
}
