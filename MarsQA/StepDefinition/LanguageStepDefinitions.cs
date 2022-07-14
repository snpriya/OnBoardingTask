using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinition
{
    [Binding]
    public class LanguageStepDefinitions:CommonDriver
    {
        [After]
        public void Dispose()
        {

            if (driver != null)
            {
                driver.Dispose();
            }
        }
        [Given(@"I logged up and go to Language page")]
        public void GivenILoggedUpAndGoToLanguagePage()
        {
            driver = new ChromeDriver();
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginSteps(driver);
        }
        [When(@"I add a Language to language page '([^']*)' '([^']*)'")]
        public void WhenIAddALanguageToLanguagePage(string language, string languagelevel)
        {
            Language languageobj = new Language();
            languageobj.addLanguage(driver, language, languagelevel);
        }

        [Then(@"The  new record  is added sucessfully '([^']*)' '([^']*)'")]
        public void ThenTheNewRecordIsAddedSucessfully(string language, string languagelevel)
        {
            Language languageobj = new Language();
            String lang = languageobj.checkaddlanguage(driver);
            String lanlevel = languageobj.checkaddlanguagelevel(driver);
            //assertion
            Assert.That(lang == language, "language is not added");
            Assert.That(lanlevel == languagelevel, "Acual value expected value not match");
        }
                
        [When(@"I update '([^']*)','([^']*)' on an existing education records")]
        public void WhenIUpdateOnAnExistingEducationRecords(string language, string level)
        {
            Language languageobj = new Language();
            languageobj.EditLanguage(driver, language, level);
        }

        [Then(@"The record is updated '([^']*)','([^']*)'")]
        public void ThenTheRecordIsUpdated(string p0, string p1)
        {
            Language languageobj = new Language();
            String lang = languageobj.checkaddlanguage(driver);
            String elevel = languageobj.checkaddlanguagelevel(driver);
            Assert.That(lang == p0, "language not edited");
            Assert.That(elevel == p1, "language level is not updated");
        }

        [When(@"I deleted the existing records using '([^']*)'")]
        public void WhenIDeletedTheExistingRecordsUsing(string language)
        {
            Language languageobj = new Language();
        }

        [Then(@"The language deleted Successfully using '([^']*)'")]
        public void ThenTheLanguageDeletedSuccessfullyUsing(string language)
        {
            Language languageobj = new Language();
            languageobj.DeleteLanguage(driver,language);
            String deletelanguage = languageobj.checkaddlanguage(driver);
            Assert.That(deletelanguage != language, "not deleted");
        }
    }
}
