using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Member_Management
{
    [TestClass]
    public class UnitTest1
    {
        DateTime Today = DateTime.Now;
        private IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        private string today;
        private string DemoBackOfficeUrl = "http://admin-demo-ng.568win.com/login";

        [TestMethod]
        public void TestAgentUpdate()
        {
            today = Today.ToString("yyyyMMdd");
            //登入Company帳號
            driver.Navigate().GoToUrl(DemoBackOfficeUrl);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("UsernameLogin")).Click();
            driver.FindElement(By.Id("UsernameLogin")).Clear();
            driver.FindElement(By.Id("UsernameLogin")).SendKeys("qatesting");
            driver.FindElement(By.Id("PasswordLogin")).Clear();
            driver.FindElement(By.Id("PasswordLogin")).SendKeys("568winwin");
            driver.FindElement(By.Id("loginForm")).Click();
            driver.FindElement(By.Id("btn-login")).Click();
            //更改Agent帳號資訊
            driver.FindElement(By.XPath("//div[@id='maincontainer']/div[2]/div/span")).Click();
            driver.FindElement(By.XPath("//div[@id='maincontainer']/div[2]/div[2]/ul/a[3]/li")).Click();
            driver.FindElement(By.XPath("//table[@id='table']/thead/tr/th/div/div[3]/div[2]/div[2]/button")).Click();
            driver.FindElement(By.XPath("//table[@id='table']/thead/tr/th/div/div[2]/button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//tbody[@id='account-list-render']/tr/td[5]/a/div")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("FirstName")).Click();
            driver.FindElement(By.Id("FirstName")).Clear();
            driver.FindElement(By.Id("FirstName")).SendKeys("QATesting" + today);

            driver.FindElement(By.Id("LastName")).Click();
            driver.FindElement(By.Id("LastName")).Clear();
            driver.FindElement(By.Id("LastName")).SendKeys("QATesting" + today);

            driver.FindElement(By.Id("Mobile")).Click();
            driver.FindElement(By.Id("Mobile")).Clear();
            driver.FindElement(By.Id("Mobile")).SendKeys(today);

            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("test" + today);
            driver.FindElement(By.Id("btn_update_account_info")).Click();

            var firstname = driver.FindElement(By.Id("FirstName"));
            Assert.AreEqual(firstname.GetAttribute("value"), "QATesting" + today);
            var lastname = driver.FindElement(By.Id("LastName"));
            Assert.AreEqual(lastname.GetAttribute("value"), "QATesting" + today);
            Thread.Sleep(5000);

            //登出Conpany帳號
            driver.FindElement(By.XPath("//input[@value='Sign Out']")).Click();
            Thread.Sleep(3000);
            //測試Agent帳號登入是否正常
            driver.FindElement(By.Id("UsernameLogin")).Click();
            driver.FindElement(By.Id("UsernameLogin")).Clear();
            driver.FindElement(By.Id("UsernameLogin")).SendKeys("qatesting01");
            driver.FindElement(By.Id("PasswordLogin")).Click();
            driver.FindElement(By.Id("PasswordLogin")).Clear();
            driver.FindElement(By.Id("PasswordLogin")).SendKeys("1234asdf");
            driver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.Id("UsernameLogin")).Click();
            driver.FindElement(By.Id("UsernameLogin")).Clear();
            driver.FindElement(By.Id("UsernameLogin")).SendKeys("qatesting01");
            driver.FindElement(By.Id("PasswordLogin")).Click();
            driver.FindElement(By.Id("PasswordLogin")).Clear();
            driver.FindElement(By.Id("PasswordLogin")).SendKeys("test" + today);
            driver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(3000);

        }
        [TestMethod]
        public void TestPlayUpdate()
        {
            driver.Navigate().GoToUrl(DemoBackOfficeUrl);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("UsernameLogin")).Click();
            driver.FindElement(By.Id("UsernameLogin")).Clear();
            driver.FindElement(By.Id("UsernameLogin")).SendKeys("qatesting");
            driver.FindElement(By.Id("PasswordLogin")).Clear();
            driver.FindElement(By.Id("PasswordLogin")).SendKeys("568winwin");
            driver.FindElement(By.Id("loginForm")).Click();
            driver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(3000);

        }
    }
}
