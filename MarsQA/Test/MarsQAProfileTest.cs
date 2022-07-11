using MarsQA.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MarsQA.Test
{
    [TestFixture]
    public class MarsQAProfileTest:CommonDriver
    {
       


     //[Test, Order(1), Description("Create certificate")]
        public void addCertificate()
        {
            //create object for certificate
            Certificate certificateobj = new Certificate();
            certificateobj.addCertificate(driver);
            certificateobj.checkAddCeritificate(driver);
        }
        public void editCertificate()
        {
            Certificate certificateobj = new Certificate();
            certificateobj.updatecertificate(driver,"dummy");
        }
        public void deletecertificate()
        {
            Certificate certificateobj = new Certificate();
            certificateobj.deletecertificate(driver,"dummy");

        }
        //[Test, Order(2), Description("Create education")]
        public void addEducation()
        {
            //creating object for education class
            Education educationobj = new Education();
            educationobj.AddEducation(driver);
            //educationobj.CheckAddEducation(driver);
        }
        public void  editeducation()
        {
            Education educationobj = new Education();
            educationobj.UpdateEducation(driver, "dummy");

        }
        public void deleteeducation()
        {
            Education educationobj = new Education();
            educationobj.DeleteEducation(driver);
        }
        //[Test, Order(3), Description("Create Language")]
        public void addlanguage()
        {
            Language languageobj = new Language();
            languageobj.addLanguage(driver);
            languageobj.checkaddlanguage(driver);
        }
       public void editlanguage()
        {
            Language languageobj = new Language();
            languageobj.EditLanguage(driver, "dummy1", "dummy2");
        }
        public void deletelanguage()
        {
            Language languageobj = new Language();
            languageobj.DeleteLanguage(driver);
        }




    }
}
