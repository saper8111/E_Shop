using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebEshopTests
{
    [TestFixture]
    public class CouponCreationTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://open-eshop.stqa.ru/oc-panel/auth/login";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void CouponCreationTest()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).Click();
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).Clear();
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).SendKeys("demo@open-eshop.com");
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).Click();
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).Clear();
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).SendKeys("demo");
            driver.FindElement(By.XPath("(//button[@type='submit'])[5]")).Click();
            driver.FindElement(By.XPath("//a/span[2]")).Click();
            driver.FindElement(By.XPath("//tr[4]/td/li/a/span")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/a")).Click();
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).Clear();
            driver.FindElement(By.Id("name")).SendKeys("test123");
            driver.FindElement(By.Id("discount_amount")).Click();
            driver.FindElement(By.Id("discount_amount")).Clear();
            driver.FindElement(By.Id("discount_amount")).SendKeys("10");
            driver.FindElement(By.Name("valid_date")).Click();
            driver.FindElement(By.Name("valid_date")).Clear();
            driver.FindElement(By.Name("valid_date")).SendKeys("20-01-14");
            driver.FindElement(By.Id("number_coupons")).Click();
            driver.FindElement(By.Id("number_coupons")).Clear();
            driver.FindElement(By.Id("number_coupons")).SendKeys("100");
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.XPath("//a[2]/span")).Click();
            driver.FindElement(By.XPath("//li[6]/a/i")).Click();
        }
    }
}
