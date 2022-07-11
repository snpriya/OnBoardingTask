using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinition
{
    [Binding]
    public class MarsQAFeatureStepDefinitions:CommonDriver
    {
        [Given(@"I logged up and navigate to education page")]
        public void GivenILoggedUpAndNavigateToEducationPage()
        {
            driver = new ChromeDriver();
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginSteps(driver);
            Education educationobj = new Education();

        }


        [When(@"I create a new education")]
        public void WhenICreateANewEducation()
        {
            //creating object for education class
            Education educationobj = new Education();
            educationobj.AddEducation(driver);
        }

        [Then(@"The  new record created sucessfully")]
        public void ThenTheNewRecordCreatedSucessfully()
        {
            Education educationobj = new Education();
            
        }
              

        [When(@"I update '([^']*)' in existing education record")]
        public void WhenIUpdateInExistingEducationRecord(string degree)
        {
            Education educationobj = new Education();
            educationobj.UpdateEducation(driver, degree);
        }

        [Then(@"The record is updated")]
        public void ThenTheRecordIsUpdated()
        {
            Education educationobj = new Education();
            String deg=educationobj.Checkupdatedegree(driver);

            Assert.That(deg != "Computer Science", "degree not updated");
        }
         
        [When(@"I deleted the existing records \.")]
        public void WhenIDeletedTheExistingRecords_()
        {
            Education educationobj = new Education();
        }
        [Then(@"The education deleted Successfully")]
        public void ThenTheEducationDeletedSuccessfully()
        {
            Education educationobj = new Education();
            educationobj.DeleteEducation(driver);
            
            
        }
        [Given(@"I logged up and navigate to certification page")]
        public void GivenILoggedUpAndNavigateToCertificationPage()
        {
            driver = new ChromeDriver();
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginSteps(driver);
            Education educationobj = new Education();
        }

        [When(@"I create a new Certification")]
        public void WhenICreateANewCertification()
        {
            Certificate certificateobj = new Certificate();
            certificateobj.addCertificate(driver);
        }

        [Then(@"The new certificate record created sucessfully")]
        public void ThenTheNewCertificateRecordCreatedSucessfully()
        {
            Certificate certificateobj = new Certificate();
            String certi = certificateobj.checkAddCeritificate(driver);
            Assert.That(certi == "Test Analyst","new certification record not created");
        }
            
        [When(@"I update '([^']*)' on an existing certificate record")]
        public void WhenIUpdateOnAnExistingCertificateRecord(string certificate)
        {
            Certificate certificateobj = new Certificate();
            certificateobj.updatecertificate(driver,certificate);
        }
        [Then(@"The record is update")]
        public void ThenTheRecordIsUpdate()
        {
            Certificate certificateobj = new Certificate();
            String cert=certificateobj.checkupdatecertificate(driver);
            Assert.That(cert != "developer", "certificate is updated");
        }



        [When(@"I deleting exist records using '([^']*)'")]
        public void WhenIDeletingExistRecordsUsing(string certificate)
        {
            driver = new ChromeDriver();
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginSteps(driver);
            Certificate certificateobj = new Certificate();
            certificateobj.deletecertificate(driver, certificate);

        }

        [Then(@"The certification deleted Successfully")]
        public void ThenTheCertificationDeletedSuccessfully()
        {
            Certificate certificateobj = new Certificate();
            
        }
        [Given(@"I logged up and navigate to Language page")]
        public void GivenILoggedUpAndNavigateToLanguagePage()
        {
            driver = new ChromeDriver();
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginSteps(driver);


        }

        [When(@"I add a Language")]
        public void WhenIAddALanguage()
        {
            Language languageobj = new Language();
        }

        [Then(@"The  new record added sucessfully")]
        public void ThenTheNewRecordAddedSucessfully()
        {
            Language languageobj = new Language();
            String lang= languageobj.checkaddlanguage(driver);
            String lanlevel = languageobj.checkaddlanguagelevel(driver);
            //assertion
            Assert.That(lang == "Hindi", "language is not added");
            Assert.That(lanlevel == "Basic", "Acual value expected value not match");
        }
          
        [When(@"I update '([^']*)','([^']*)' on an existing education record")]
        public void WhenIUpdateOnAnExistingEducationRecord(string p0, string p1)
        {
            Language languageobj = new Language();
            languageobj.EditLanguage(driver, p0,p1);
        }

        [Then(@"The record is update '([^']*)','([^']*)'")]
        public void ThenTheRecordIsUpdate(string p0, string p1)
        {
            Language languageobj = new Language();
            String lang = languageobj.checkeditlanguage(driver);
            String elevel = languageobj.checkeditlanguagelevel(driver);
            Assert.That(lang == p0, "language not edited");
           Assert.That(elevel == p1, "language level is not updated");
        }

        [When(@"I deleted the existing records")]
        public void WhenIDeletedTheExistingRecords()
        {
            Language languageobj = new Language();
            
        }

        [Then(@"The language deleted Successfully")]
        public void ThenTheLanguageDeletedSuccessfully()
        {
            Language languageobj = new Language();
            languageobj.DeleteLanguage(driver);
            
           
        }
    }
}
