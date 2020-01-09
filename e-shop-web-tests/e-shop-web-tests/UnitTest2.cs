using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace e_shop_web_tests
{
    [TestFixture]
    public class Login
    {

        public static String TEST_RUN_ID = "281";
        public static String m_user = "Vyacheslav.Kozhurov@dhl.ru";
        public static String m_password = "1xVixA7Ug7q4Ys1di36M";
        public static String m_url = "https://dhlru.testrail.io/";
        public static  int TEST_CASE_PASSED_STATUS = 1;
        public static int TEST_CASE_FAILED_STATUS = 5;
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
      

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
        public void TheLoginTest()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).Click();
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).Clear();
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).SendKeys("demo@open-eshop.com");
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).Click();
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).Clear();
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).SendKeys("demo");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Register'])[5]/following::button[1]")).Click();
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[2]/a/i")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
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

        public static void addResultForTestCase(String case_id, int status, String error) {



        }

        /*private bool IsAlertPresent()
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
        }*/
    }
}
