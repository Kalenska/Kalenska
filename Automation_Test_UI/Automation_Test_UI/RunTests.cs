using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation_Test_UI
{
    [TestClass]
    public class Test
    {
       // private IWebDriver driver;
       // [TestCleanup]
       // public void CleanUp()
       //{
       //     driver.Quit();
      //  }

        [TestMethod]
  
        public void ExecuteLoginTest()
        {
           //  LoginPage loginpage = new LoginPage();
           //  loginpage.Login_With_Valid_Email_And_Password(); // ok
          //   loginpage.Login_With_Invalid_Email_And_Password(); // ok
          //   loginpage.Registration_Link_Can_Be_Opened(); //ok
        }

        [TestMethod]
        public void ExecuteRegisterTest()
        {
            Registration register = new Registration();
           register.Register_With_All_Required_Fields();
        }

  
    }
}
