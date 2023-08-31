using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace BankTests
{
    [TestClass]
    public class TestInit
    {
        public IWebDriver driver;
     
        [TestInitialize]
        public void openBrowser()
        {
            driver = new FirefoxDriver("C:\\WebDriver\\bin\\geckodriver.exe");
        }

        public IWebDriver getDriver()
        {
            return driver;
        }

        [TestCleanup]
        public void closeBrowser()
        {
            driver.Close();
        }

      
    }
}
