using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTests.test.pageObjects
{
    class AmazonPage : BasePage
    {
        public AmazonPage(IWebDriver driver) : base(driver) { }

        public IWebElement getTitleField()
        {
            return getElementByXpath("//a[@id='nav-logo-sprites']");
        }
        public IWebElement getDeliverText()
        {
            return getElementByXpath("//a[@id='nav-global-location-popover-link']");
        }
        public IWebElement getSearchInput()
        {
            return getElementByXpath("//input[@id='twotabsearchtextbox']");
        }
        public IWebElement getSearchBtn()
        {
            return getElementByXpath("//input[@id='nav-search-submit-button']");
        }
        public IWebElement getLanguageSelect()
        {
            return getElementByXpath("//a[@id='icp-nav-flyout']");
        }
        public IWebElement getLoginField()
        {
            return getElementByXpath("//a[@id='nav-link-accountList']");
        }
        public IWebElement getNavOrders()
        {
            return getElementByXpath("//a[@id='nav-orders']");
        }
        public IWebElement getShoppingCart()
        {
            return getElementByXpath("//a[@id='nav-cart']");
        }
        public void goToAmazon()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com/");
        }
    }
}
