using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_Test_UI
{
    [TestClass]
    [TestCategory("Registration")]
    public class Registration
    {
        private GetChromeDriver getChromeDriver = new GetChromeDriver();
        private IWebDriver driver;
        private IWebElement _email;
        private IWebElement _title;
        private IWebElement _firstName;
        private IWebElement _familyName;
        private IWebElement _submitButton;

        public void Register_With_All_Required_Fields()
        {
            driver = getChromeDriver.CreateDriver();
            driver.Navigate().GoToUrl("http://vm-asc-rsm-merc.ascent.com.mt:7000/_layouts/15/RSM.ConnectPlus/Register.aspx");

            _email = driver.FindElement(By.Id("txtEmail"));
            _email.Clear();
            _email.SendKeys("johnGeller2@rsm.com.mt");

            _title = driver.FindElement(By.Id("txtTitle"));
            _title.Clear();
            _title.SendKeys("Mr");

            _firstName = driver.FindElement(By.Id("txtFirstName"));
            _firstName.Clear();
            _firstName.SendKeys("John");

            _familyName = driver.FindElement(By.Id("txtFamilyName"));
            _familyName.Clear();
            _familyName.SendKeys("Geller");

            var firm = driver.FindElements(By.XPath("//a[@class='chosen-single']"))[1];
            firm.Click();
            var firmDropDown = driver.FindElement(By.XPath("//span[contains(text(),'RSM Malta')]"));
            firmDropDown.Click();
     
            _submitButton = driver.FindElement(By.Id("submitButton"));
            _submitButton.Submit();

        }

        public void Cannot_Register_With_Already_Registered_Email()
        {

        }





    }
}
