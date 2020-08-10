using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AutomationTests.ConfigElements
{
    public static class Driver {
        // Privatize the _webDriver member; use the WebDriver as the only external exposure to the driver
        private static IWebDriver _webDriver;
        private static OpenQA.Selenium.Cookie cfCookie;

        public static IWebDriver driver { get; set; }

        public static IWebDriver WebDriver {


            get {
                // _webDriver = _webDriver == null ? GetWebDriver : _webDriver
                _webDriver = _webDriver ?? GetWebDriver();
                return _webDriver;
                
            }
        }

        private static IWebDriver GetWebDriver()
        {



            var webDriver = new ChromeDriver();



            // Obtain JWT and set corresponding cookie if cookie is null.
            if (cfCookie == null)
            {
                System.Console.WriteLine("CF Cookie is null. Obtaining JWT.");



                var dateString = "5/1/2030 8:30:52 AM";
                DateTime date1 = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);



                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebRequest webRequest = WebRequest.Create("https://www.staging.juiceplus.com/ie/en");
                webRequest.Method = "GET";
                webRequest.Headers.Add("CF-Access-Client-Id", "98a633422b00f013a1bbbbe1c184c81b.access");
                webRequest.Headers.Add("CF-Access-Client-Secret", "352e8f81cde3597cf67c1a02c3d5b65245245d964d71baa3e4dd815b2a5fd3a0");
                webRequest.ContentType = "application/x-www-form-urlencoded";



                var regex = new Regex(@"CF_Authorization=.*?;");
                var magicCookie = "";



                if (regex.Matches(webRequest.GetResponse().Headers.Get("set-cookie")).Count > 0)
                {
                    magicCookie = regex.Matches(webRequest.GetResponse().Headers.Get("set-cookie"))[0].Value.Replace("CF_Authorization=", "").Replace(";", "");
                }



                System.Console.WriteLine("magicCookie: " + magicCookie);



                cfCookie = new OpenQA.Selenium.Cookie("CF_Authorization", magicCookie, "www.staging.juiceplus.com", "/", date1);
            }
            else
            {
                System.Console.WriteLine("CF Cookie is NOT null. Utilizing existing CF JWT Cookie.");
            }



            webDriver.Manage().Window.Maximize();



            if (cfCookie.Value.Length > 1)
            {
                webDriver.Navigate().GoToUrl(Config.Config.BaseURL);
                webDriver.Manage().Cookies.AddCookie(cfCookie);
            }



            webDriver.Navigate().GoToUrl(Config.Config.BaseURL);



            WaitForElementUpTo(webDriver, Config.Config.ElementsWaitingTimeout);
            return webDriver;



        }

        private static void WaitForElementUpTo(IWebDriver webDriver, int seconds = 10) {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public static void Teardown() {
            _webDriver.Quit();
            _webDriver = null;
        }

        public static void InitializeDriver()
        {
            Driver._webDriver = new ChromeDriver();
            Driver._webDriver.Manage().Window.Maximize();
        }

    }
}
