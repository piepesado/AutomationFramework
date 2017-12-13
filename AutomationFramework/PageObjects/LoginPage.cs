using System;
using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ApexPortal.Login.Pages
{
    public class LoginPage : BasePage
    {
        private const string AUT_URL = "http://URL.com";

        //Objects
        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement _userName;        

        public string Username
        {
            get
            {
                return _userName.Text;
            }
            set
            {
                _userName.SendKeys(value);
            }
        }        

        //Actions
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public static LoginPage NavigateTo(IWebDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver));
            }

            driver.Navigate().GoToUrl(AUT_URL);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.Equals("Page Title"));
            return new LoginPage(driver);
        }

        /*
        public HomePage Login()
        {
            _loginButton.Click();
            return new HomePage(_driver);
        }
        */
    }
}

