using System;
using System.Text;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

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

        public static APIClient APIClient { get; private set; }

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
        public void TheUntitledTestCaseTest()
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
            driver.FindElement(By.Id("discount_amount")).SendKeys("155");
            driver.FindElement(By.Name("valid_date")).Click();
            driver.FindElement(By.Name("valid_date")).Clear();
            driver.FindElement(By.Name("valid_date")).SendKeys("12122020");
            driver.FindElement(By.XPath("//form/div[5]/div")).Click();
            driver.FindElement(By.Id("number_coupons")).Click();
            driver.FindElement(By.Id("number_coupons")).Clear();
            driver.FindElement(By.Id("number_coupons")).SendKeys("700");
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.XPath("//a[contains(@href, '#')]")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        private void OpenHomePage()
        {
          
            driver.Navigate().GoToUrl(baseURL);
        }

        private void LoginPage()
        {
            
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).Click();
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).Clear();
            driver.FindElement(By.XPath("(//input[@name='email'])[4]")).SendKeys("demo@open-eshop.com");
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).Click();
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).Clear();
            driver.FindElement(By.XPath("(//input[@name='password'])[2]")).SendKeys("demo");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Register'])[5]/following::button[1]")).Click();
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

           APIClient client = new APIClient(m_url);
            client.User = m_user;
            client.Password = m_password;
            JObject c = (JObject)client.SendGet("get_case/1182");
            Console.WriteLine(c["title"]);



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
