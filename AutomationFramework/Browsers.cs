using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace AutomationFramework
{
    class Browsers
    {
        private static IWebDriver webDriver;
        private static String baseUrl = ConfigurationManager.AppSettings["URL"];
        private static String browser = ConfigurationManager.AppSettings["Browser Name"];

        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
            //goto (baseUrl);
        }

        public static String Title
        {
            get { return webDriver.Title; }
        }

    }
}

