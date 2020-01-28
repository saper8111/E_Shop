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
    public class CouponRemovalTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
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
        public void CouponRemovalTest()
        {
            driver.Navigate().GoToUrl("http://open-eshop.stqa.ru/oc-panel/auth/login");
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).Click();
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).Clear();
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).SendKeys("demo@open-eshop.com");
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).Click();
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).Clear();
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).SendKeys("demo");
            driver.FindElement(By.XPath("(//button[@type='submit'])[5]")).Click();
            driver.FindElement(By.XPath("//a/span[2]")).Click();
            driver.FindElement(By.XPath("//tr[4]/td/li/a/span")).Click();
            driver.FindElement(By.Name("name")).Click();
            driver.FindElement(By.Name("name")).Clear();
            driver.FindElement(By.Name("name")).SendKeys("test123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.XPath("//td[7]/a[2]/i")).Click();
            driver.FindElement(By.XPath("//button[2]")).Click();
            driver.FindElement(By.XPath("//a[2]/span")).Click();
            driver.FindElement(By.XPath("//li[6]/a/i")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
