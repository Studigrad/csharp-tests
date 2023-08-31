using BankTests.test.pageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTests.test.tests
{
    [TestClass]
    public class GoogleTest : TestInit
    {
        [TestMethod]
        public void RunGoogle()
        {
            GooglePage newTab = new GooglePage(getDriver());
            newTab.goToGoogle();
            newTab.getSearchField().SendKeys("dogs\n");
            Assert.IsNotNull(newTab.getSearchField());
        }
    }
}