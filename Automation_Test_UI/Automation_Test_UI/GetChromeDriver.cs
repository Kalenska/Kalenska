using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Automation_Test_UI
{
    internal class GetChromeDriver
    {
        //  public IWebDriver GetChromeDriver()
        //  {
        //       var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //       return new ChromeDriver(outPutDirectory);
        //   }

        public IWebDriver CreateDriver()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--headless");

            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(15);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            return driver;
        }

        internal object Navigate()
        {
            throw new NotImplementedException();
        }
    }
}