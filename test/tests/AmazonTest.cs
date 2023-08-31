using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using BankTests.test.pageObjects;

namespace BankTests.test.tests
{
    [TestClass]
    public class AmazonTest : TestInit
    {
     
        [TestMethod]
        public void checkHeader()
        {
            AmazonPage newPage = new AmazonPage(driver);
            newPage.goToAmazon();

            Assert.IsTrue(newPage.getTitleField().Displayed);
            Assert.IsTrue(newPage.getDeliverText().Displayed);
            Assert.IsTrue(newPage.getSearchInput().Displayed);
            Assert.IsTrue(newPage.getSearchBtn().Displayed);
            Assert.IsTrue(newPage.getLanguageSelect().Displayed);
            Assert.IsTrue(newPage.getLoginField().Displayed);
            Assert.IsTrue(newPage.getNavOrders().Displayed);
            Assert.IsTrue(newPage.getShoppingCart().Displayed);

        }
        [TestMethod]
        public void checkAgainHeader()
        {
            AmazonPage newPage = new AmazonPage(driver);
            newPage.goToAmazon();

            Assert.IsTrue(newPage.getTitleField().Displayed);
            Assert.IsTrue(newPage.getDeliverText().Displayed);
            Assert.IsTrue(newPage.getSearchInput().Displayed);
            Assert.IsTrue(newPage.getSearchBtn().Displayed);
            Assert.IsTrue(newPage.getLanguageSelect().Displayed);
            Assert.IsTrue(newPage.getLoginField().Displayed);
            Assert.IsTrue(newPage.getNavOrders().Displayed);
            Assert.IsTrue(newPage.getShoppingCart().Displayed);

        }


    }
}
