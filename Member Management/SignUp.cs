using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        private string AgentOfflineUrl = "https://demo-ng-104.568win.com/join-now?ca=qatesting03";
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
            driver.Navigate().GoToUrl(AgentOfflineUrl);

            driver.FindElement(By.Id("RegisterUsername")).Click();
            driver.FindElement(By.Id("RegisterUsername")).Clear();
            driver.FindElement(By.Id("RegisterUsername")).SendKeys("AgentOffline" + today);

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


            driver.FindElement(By.Id("btn-joinnow")).Click();

        }
        [TestMethod]
        public void AgentBackOffice()
        {
            today = Today.ToString("yyyyMMdd");

            driver.Navigate().GoToUrl(BackOfficeUrl);

            driver.FindElement(By.Id("UsernameLogin")).Click();
            driver.FindElement(By.Id("UsernameLogin")).Clear();
            driver.FindElement(By.Id("UsernameLogin")).SendKeys("qatesting03");

            driver.FindElement(By.Id("PasswordLogin")).Click();
            driver.FindElement(By.Id("PasswordLogin")).Clear();
            driver.FindElement(By.Id("PasswordLogin")).SendKeys("568winwin");
            driver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//div[@id='maincontainer']/div[17]/div")).Click();
            driver.FindElement(By.XPath("//div[@id='maincontainer']/div[17]/div[2]/ul/a/li")).Click();
            driver.FindElement(By.Name("AccountType")).Click();

            new SelectElement(driver.FindElement(By.Name("AccountType"))).SelectByText("Player");

            driver.FindElement(By.Id("NewUsernameCashAgent")).Click();
            driver.FindElement(By.Id("NewUsernameCashAgent")).Clear();
            driver.FindElement(By.Id("NewUsernameCashAgent")).SendKeys("BackOffice" + today);

            driver.FindElement(By.Name("CompanyFlowSettings[FirstName]")).Click();
            driver.FindElement(By.Name("CompanyFlowSettings[FirstName]")).Clear();
            driver.FindElement(By.Name("CompanyFlowSettings[FirstName]")).SendKeys("QATest");

            driver.FindElement(By.Name("CompanyFlowSettings[LastName]")).Click();
            driver.FindElement(By.Name("CompanyFlowSettings[LastName]")).Clear();
            driver.FindElement(By.Name("CompanyFlowSettings[LastName]")).SendKeys("QATest");

            driver.FindElement(By.Id("NewPassword")).Click();
            driver.FindElement(By.Id("NewPassword")).Clear();
            driver.FindElement(By.Id("NewPassword")).SendKeys("test" + today);

            driver.FindElement(By.Id("ConfirmPassword")).Click();
            driver.FindElement(By.Id("ConfirmPassword")).Clear();
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("test" + today);

            driver.FindElement(By.Name("CompanyFlowSettings[Email]")).Click();
            driver.FindElement(By.Name("CompanyFlowSettings[Email]")).Clear();
            driver.FindElement(By.Name("CompanyFlowSettings[Email]")).SendKeys(today+"@QATest.com");

            driver.FindElement(By.Name("CompanyFlowSettings[Phone]")).Click();
            driver.FindElement(By.Name("CompanyFlowSettings[Phone]")).Clear();
            driver.FindElement(By.Name("CompanyFlowSettings[Phone]")).SendKeys("0912345678");
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Next'])[1]/following::button[1]")).Click();
        }

    }
}
