using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using MarsQA.Pages.Profile;

namespace MarsQA.Test
{
    [TestFixture]
    public class MarsQAProfileTest:CommonDriver
    {
       


     //[Test, Order(1), Description("Create certificate")]
        public void addCertificate()
        {
            //create object for certificate
            var certificateobj = new Certificate(driver);
            certificateobj.addCertificate(driver,"dummy1","dummy2","dummy3");
            certificateobj.checkCeritificate(driver);
        }
        public void editCertificate()
        {
            Certificate certificateobj = new Certificate(driver);
            //certificateobj.updatecertificate(driver,"dummy","dummy1","dummy2");
        }
        public void deletecertificate()
        {
            Certificate certificateobj = new Certificate(driver);
            certificateobj.deletecertificate(driver,"dummy");

        }
        //[Test, Order(2), Description("Create education")]
        public void addEducation()
        {
            //creating object for education class
            Education educationobj = new Education(driver);
            educationobj.AddEducation(driver,"dummy","dummy1","dummy2","dummy3","dummy4");
            //educationobj.CheckAddEducation(driver);
        }
        public void  editeducation()
        {
            Education educationobj = new Education(driver);
            educationobj.UpdateEducation(driver, "dummy","dummy1","dummy2","dummy3","dummy4");

        }
        public void deleteeducation()
        {
            Education educationobj = new Education(driver);
            educationobj.DeleteEducation(driver,"dummy");
        }
        //[Test, Order(3), Description("Create Language")]
        public void addlanguage()
        {
            Language languageobj = new Language(driver);
            languageobj.addLanguage(driver,"dummy","dummy1");
            languageobj.checkaddlanguage(driver);
        }
       public void editlanguage()
        {
            Language languageobj = new Language(driver);
            languageobj.EditLanguage(driver, "dummy1", "dummy2");
        }
        public void deletelanguage()
        {
            Language languageobj = new Language(driver);
            languageobj.DeleteLanguage(driver,"dummy");
        }




    }
}
