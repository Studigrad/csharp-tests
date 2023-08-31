using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTests.test.pageObjects
{
    class BasePage
    {
        public IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement getElementByXpath(String path)
        {
            return driver.FindElement(By.XPath(path));
        }
    }
}
