using MarsQA.Pages;
using MarsQA.Pages.Profile;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinition
{
    [Binding]
    [TestFixture]
    public class CertificateStepDefinitions:CommonDriver
    {
        [After]
        public void dispose()
        {
            if(driver!=null)
            {
                driver.Close();
            }
        }
        Certificate certificateobj;
        LoginPage loginpageobj;

        public CertificateStepDefinitions()
        {
            certificateobj = new Certificate(driver);
        }
       
        [Given(@"I logged up and go to certification page")]
        public void GivenILoggedUpAndGoToCertificationPage()
        {
            driver = new ChromeDriver();
            loginpageobj = new LoginPage(driver);
            loginpageobj.LoginSteps(driver);
             certificateobj = new Certificate(driver);
        }
        [When(@"I create a new Certifications using '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenICreateANewCertificationsUsing(string p0, string p1, string p2)
        {
             certificateobj = new Certificate(driver);
            certificateobj.addCertificate(driver, p0, p1, p2);

        }

        [Then(@"The new certificate record added sucessfully'([^']*)' '([^']*)' '([^']*)'")]
        public void ThenTheNewCertificateRecordAddedSucessfully(string p0, string p1, string p2)
        {
             certificateobj = new Certificate(driver);
            String certi = certificateobj.checkCeritificate(driver);
            String certifrom = certificateobj.checkcertificatefrom(driver);
            String certiyear = certificateobj.checkcertificateyear(driver);
            Assert.That(certi == p0, "new certification record not created");
            Assert.That(certifrom == p1, "new certification record not created");
            Assert.That(certiyear == p2, "year not added");
        }
        [When(@"I update '([^']*)' '([^']*)' '([^']*)' on an existing certificate record")]
        public void WhenIUpdateOnAnExistingCertificateRecord(string ecertificate, string efrom, string eyear)
        {
             certificateobj = new Certificate(driver);
            certificateobj.updatecertificate(driver, ecertificate, efrom,eyear);
        }

        [Then(@"The record will be updated using '([^']*)' '([^']*)' '([^']*)'")]
        public void ThenTheRecordWillBeUpdatedUsing(string ecertificate, string efrom, string eyear)
        {
             certificateobj = new Certificate(driver);
            String cert = certificateobj.checkCeritificate(driver);
            String certifrom = certificateobj.checkcertificatefrom(driver);
            Assert.That(cert == ecertificate, "certificate is not updated");
            Assert.That(certifrom == efrom, "certifrom not updated");
        }
                       
        [When(@"I delete existing record using '([^']*)'")]
        public void WhenIDeleteExistingRecordUsing(string certificate)
        {
            //driver = new ChromeDriver();
            //LoginPage loginpageobj = new LoginPage();
            //loginpageobj.LoginSteps(driver);
             certificateobj = new Certificate(driver);
            certificateobj.deletecertificate(driver, certificate);
        }

        
        [Then(@"The existing certification deleted Successfully '([^']*)'")]
        public void ThenTheExistingCertificationDeletedSuccessfully(string certificate)
        {
             certificateobj = new Certificate(driver);
            String delcerti = certificateobj.delcertificate(driver);
            Assert.That(delcerti != certificate, "not deleted");
        }

    }
}
