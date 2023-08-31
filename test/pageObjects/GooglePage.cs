using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTests.test.pageObjects
{
    class GooglePage : BasePage
    {
     
        public GooglePage(IWebDriver driver) : base(driver)
        {
           
        }
        public IWebElement getSearchField()
        {
            return getElementByXpath("//textarea[@id='APjFqb']");
        }
        public void goToGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com.ua/");
        }
    }
}
