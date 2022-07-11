using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MarsQA.Pages;

namespace MarsQA.Utilities
{
    [TestFixture]
    public class CommonDriver
    {
        public IWebDriver driver;

        LoginPage loginpageobj = new LoginPage();
        [OneTimeSetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();
            
            loginpageobj.LoginSteps(driver);
        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
