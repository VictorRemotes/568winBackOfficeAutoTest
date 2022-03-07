using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Member_Management
{
    [TestClass]
    public class SignUp
    {
        DateTime Today = DateTime.Now;
        private IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        private string today;
        private string BackOfficeUrl = "http://admin-demo-ng.568win.com/login";
        private string PlayerSiteUrl = "http://demo-ng-104.568win.com";

        [TestMethod]
        public void CompanyOffline()
        {
            today = Today.ToString("yyyyMMdd");
            driver.Navigate().GoToUrl(PlayerSiteUrl);
            driver.FindElement(By.LinkText("Join Now FREE")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.Id("RegisterUsername")).Click();
            driver.FindElement(By.Id("RegisterUsername")).Clear();
            driver.FindElement(By.Id("RegisterUsername")).SendKeys("OfflineTest" + today);

            driver.FindElement(By.Id("Registerpassword")).Click();
            driver.FindElement(By.Id("Registerpassword")).Clear();
            driver.FindElement(By.Id("Registerpassword")).SendKeys("Password" + today);

            driver.FindElement(By.Id("confirm_password")).Click();
            driver.FindElement(By.Id("confirm_password")).Clear();
            driver.FindElement(By.Id("confirm_password")).SendKeys("Password" + today);

            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys(today + "@test.com");

            driver.FindElement(By.Id("Phone")).Click();
            driver.FindElement(By.Id("Phone")).Clear();
            driver.FindElement(By.Id("Phone")).SendKeys(today);

       
            driver.FindElement(By.Id("sign-up-form")).Click();

        }

        [TestMethod]
        public void AgentOffline()
        {
            today = Today.ToString("yyyyMMdd");

        }

    }
}
