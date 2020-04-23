using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_Test_UI
{
    [TestClass]
    [TestCategory("Login")]
    public class LoginPage
    {
        private GetChromeDriver getChromeDriver = new GetChromeDriver();
        private IWebDriver driver;
        private IWebElement _email;
        private IWebElement _password;
        private IWebElement _submitButton;

        public void Login_With_Valid_Email_And_Password()
        {
            driver = getChromeDriver.CreateDriver();
            driver.Navigate().GoToUrl("http://vm-asc-rsm-merc.ascent.com.mt:7000/_layouts/15/RSM.ConnectPlus/Login.aspx?ReturnUrl=%2f_layouts%2f15%2fAuthenticate.aspx%3fSource%3d%252F&Source=%2F");
            _email = driver.FindElement(By.Id("ctl00_PlaceHolderMain_txtEmail"));
            _email.Clear();
            _email.SendKeys("rsmadmin@ascentsoftware.eu");

            _password = driver.FindElement(By.Id("ctl00_PlaceHolderMain_txtPassword"));
            _password.Clear();
            _password.SendKeys("RSM0001!");

            _submitButton = driver.FindElement(By.Id("ctl00_PlaceHolderMain_cmdsubmit"));
            _submitButton.Submit();
            Assert.AreEqual("Landing", driver.Title);
        }

        public void Login_With_Invalid_Email_And_Password()
        {
            driver = getChromeDriver.CreateDriver();
            driver.Navigate().GoToUrl("http://vm-asc-rsm-merc.ascent.com.mt:7000/_layouts/15/RSM.ConnectPlus/Login.aspx?ReturnUrl=%2f_layouts%2f15%2fAuthenticate.aspx%3fSource%3d%252F&Source=%2F");
            _email = driver.FindElement(By.Id("ctl00_PlaceHolderMain_txtEmail"));
            _email.Clear();
            _email.SendKeys("automationtest@ascentsoftware.eu");

            _password = driver.FindElement(By.Id("ctl00_PlaceHolderMain_txtPassword"));
            _password.Clear();
            _password.SendKeys("RSM0001!");

            _submitButton = driver.FindElement(By.Id("ctl00_PlaceHolderMain_cmdsubmit"));
            _submitButton.Submit();
            //HTML to be checked for the error message.
            var errorMessage = driver.FindElement(By.XPath("//*[contains(@class,'ng-binding')]"));
            string ErrorMessagText = errorMessage.Text;
            string actualMessageText = "A login failure has occurred. Kindly check that your username and password are correct, otherwise check your inbox for further instructions.";
            Assert.AreEqual(ErrorMessagText, actualMessageText);
        }

        public void Registration_Link_Can_Be_Opened()
        {
            driver = getChromeDriver.CreateDriver();
            driver.Navigate().GoToUrl("http://vm-asc-rsm-merc.ascent.com.mt:7000/_layouts/15/RSM.ConnectPlus/Login.aspx?ReturnUrl=%2f_layouts%2f15%2fAuthenticate.aspx%3fSource%3d%252F&Source=%2F");
            driver.FindElement(By.Id("lnkNewUser")).Click();
            Assert.AreEqual("RSM Connect Register Page", driver.Title);
        }
    }
}

