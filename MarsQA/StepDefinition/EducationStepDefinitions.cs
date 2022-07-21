using MarsQA.Pages;
using MarsQA.Pages.Profile;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinition
{
    [Binding]
    [TestFixture]
    public class EducationStepDefinitions:CommonDriver
    {
        [After]
        public void dispose()
        {
            if (driver != null)
            {
                driver.Close();
            }
        }
        Education educationobj;
        LoginPage loginpageobj;
        public EducationStepDefinitions()
        {
            educationobj = new Education(driver);
            loginpageobj = new LoginPage(driver);
        }
        [Given(@"I logged up and go to education page")]
        public void GivenILoggedUpAndGoToEducationPage()
        {
            driver = new ChromeDriver();
             loginpageobj = new LoginPage(driver);
            loginpageobj.LoginSteps(driver);
             educationobj = new Education(driver);
            
        }
        [When(@"I create a new education record '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenICreateANewEducationRecord(string country, string university, string coursetitle, string degree, string year)
        {
             educationobj = new Education(driver);
            educationobj.AddEducation(driver, country, university, coursetitle, degree, year);

        }

        [Then(@"The  new record  is created sucessfully '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void ThenTheNewRecordIsCreatedSucessfully(string country, string university, string coursetitle, string degree, string year)
        {
            Education educationobj = new Education(driver);
            String addcountry = educationobj.checkcountry(driver);
            String adduniversity = educationobj.checkuniversity(driver);
            String addcourse = educationobj.checktitlecourse(driver);
            String adddegree = educationobj.checkdegree(driver);
            String addyear = educationobj.checkyear(driver);
            Assert.That(addcountry == country, "country not added");
            Assert.That(adduniversity == university, "university not added");
            Assert.That(addcourse == coursetitle, "course title not added");
            Assert.That(adddegree == degree, "degree not added");
            Assert.That(addyear == year, "year not added");
            }
        [When(@"I update '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)' in existing education record")]
        public void WhenIUpdateInExistingEducationRecord(string country, string university, string coursetitle, string degree, string year)
        {
             educationobj = new Education(driver);
            educationobj.UpdateEducation(driver, country, university, coursetitle, degree, year);
            
        }

        [Then(@"The record is updated successfully '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void ThenTheRecordIsUpdatedSuccessfully(string p1, string university, string coursetitle, string p4, string p5)
        {
             educationobj = new Education(driver);
            String editcountry = educationobj.checkeditcountry(driver);
            String editdegree = educationobj.checkeditdegree(driver);
            String edityear = educationobj.checkedityear(driver);
            Assert.That(editcountry != p1, "country not edited");
            
            Assert.That(editdegree == p4, "degree not edited");
            Assert.That(edityear == p5, "year not edited");
        }

        
                 
        [When(@"I deleted the existing records using'([^']*)' \.")]
        public void WhenIDeletedTheExistingRecordsUsing_(string degree)
        {
             educationobj = new Education(driver);
            educationobj.DeleteEducation(driver, degree);
        }
        [Then(@"The education is deleted Successfully'([^']*)'")]
        public void ThenTheEducationIsDeletedSuccessfully(string degree)
        {
             educationobj = new Education(driver);
            
            String deldegree=educationobj.checkdegree(driver);
            Assert.That(deldegree != degree, "not deleted");
        }

        
    }
}
