using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace AutomationTests.ConfigElements
{
    public class Driver
    {

        // Privatize the _webDriver member; use the WebDriver as the only external exposure to the driver
        private IWebDriver _webDriver;
        private BrowserType _browserType;
        private OpenQA.Selenium.Cookie cfCookie;

        static protected ExtentReports _extent;
        static protected ExtentTest _test;

        public enum BrowserType
        {
            Chrome,
            Firefox,
            IE,
            Edge,
            Headless,
            Remote
        }

        public Driver(BrowserType browserType)
        {
            // Check for brower parameter and override browserType if given.
            String browserParameter = TestContext.Parameters.Get("browser", "");
            if (browserParameter.Equals("Chrome"))
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--ignore-certificate-errors");
                browserType = BrowserType.Chrome;
            }
            else if (browserParameter.Equals("Firefox"))
            {
                browserType = BrowserType.Firefox;
            }
            else if (browserParameter.Equals("Edge"))
            {
                browserType = BrowserType.Edge;
            }
            else if (browserParameter.Equals("IE"))
            {
                browserType = BrowserType.IE;
            }
            else if (browserParameter.Equals("Headless"))
            {
                browserType = BrowserType.Headless;
            }
            else if (browserParameter.Equals("Remote"))
            {
                browserType = BrowserType.Remote;
            }

            // Intialize corresponding driver based on desired browser type.
            _browserType = browserType;
            if (browserType == BrowserType.Chrome)
            {
                // _webDriver = new ChromeDriver();
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                options.AcceptInsecureCertificates = true;
                _webDriver = new ChromeDriver(options);
                // _webDriver = new RemoteWebDriver(new Uri("http://memitrdp:4444/wd/hub"), options);
            }
            else if (browserType == BrowserType.Firefox)
            {
                FirefoxOptions firefoxOptions = new FirefoxOptions();
                firefoxOptions.AcceptInsecureCertificates = true;
                _webDriver = new FirefoxDriver();
            }
            else if (browserType == BrowserType.IE)
            {
                InternetExplorerOptions internetExplorerOptions = new InternetExplorerOptions();
                internetExplorerOptions.IgnoreZoomLevel = true;
                internetExplorerOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                internetExplorerOptions.UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss;
                _webDriver = new InternetExplorerDriver(internetExplorerOptions);
            }
            else if (browserType == BrowserType.Edge)
            {
                _webDriver = new EdgeDriver();
            }
            else if (browserType == BrowserType.Headless)
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments(new string[] { "--headless", "--disable-gpu", "--enable-javascript", "--no-sandbox", "'window-size=1920x1080" });
                _webDriver = new ChromeDriver(chromeOptions);
            }
            else if (browserType == BrowserType.Remote)
            {
                // _webDriver = new ChromeDriver();
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                options.AcceptInsecureCertificates = true;
                // _webDriver = new ChromeDriver(options);
                _webDriver = new RemoteWebDriver(new Uri("http://memitrdp:4444/wd/hub"), options);
            }
        }

        public IWebDriver WebDriver
        {
            get
            {
                _webDriver = _webDriver ?? GetWebDriver();
                return _webDriver;
            }
        }

        private IWebDriver GetWebDriver()
        {
            var webDriver = new ChromeDriver();

            // Obtain JWT and set corresponding cookie if cookie is null.
            if (cfCookie == null)
            {
                System.Console.WriteLine("CF Cookie is null. Obtaining JWT.");

                var dateString = "5/1/2030 8:30:52 AM";
                DateTime date1 = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebRequest webRequest = WebRequest.Create("https://prod.juiceplus.com/mx/en");
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

            // webDriver.Navigate().GoToUrl(Config.Config.BaseURL);

            WaitForElementUpTo(webDriver, Config.Config.ElementsWaitingTimeout);
            return webDriver;
        }

        private void WaitForElementUpTo(IWebDriver webDriver, int seconds = 10)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public void Teardown()
        {
            _webDriver.Quit();
            _webDriver = null;
        }

        public void InitializeDriver()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();

            /*string USERNAME = "diannkelley1";
            string AUTOMATE_KEY = "Cegxz8p89wZFzY7N5VYW";
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "80");
            caps.SetCapability("browserstack.user", USERNAME);
            caps.SetCapability("browserstack.key", AUTOMATE_KEY);
            caps.SetCapability("name", "diannkelley1's First Test");
            _webDriver = new RemoteWebDriver(
              new Uri("https://hub-cloud.browserstack.com/wd/hub/"), caps
            );
            _webDriver.Manage().Window.Maximize();*/
        }

        public void InitializeDriver(ChromeOptions options)
        {
            _webDriver = new ChromeDriver(options);
            _webDriver.Manage().Window.Maximize();
        }

        public void InitializeDriver(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
            {
                _webDriver = new ChromeDriver();
            }
            else if (browserType == BrowserType.Firefox)
            {
                _webDriver = new FirefoxDriver();
            }
            else if (browserType == BrowserType.IE)
            {
                InternetExplorerOptions internetExplorerOptions = new InternetExplorerOptions();
                internetExplorerOptions.IgnoreZoomLevel = true;
                internetExplorerOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                _webDriver = new InternetExplorerDriver(internetExplorerOptions);
            }
            else if (browserType == BrowserType.Edge)
            {
                _webDriver = new EdgeDriver();
            }
            _webDriver.Manage().Window.Maximize();
        }

        public String GetUrl(String application, String country)
        {
            String testEnvironment = TestContext.Parameters.Get("testEnvironment", "STG");
            String urlLocator = "applicationNameUrl_countryCode_env".Replace("applicationName", application).Replace("countryCode", country).Replace("env", testEnvironment);
            // Console.WriteLine("urlLocator: " +  urlLocator);
            String url = Config.Config.urlDictionary[urlLocator];

            return url;
        }

        public String GetUrl(String application)
        {
            String testEnvironment = TestContext.Parameters["testEnvironment"] ?? "STG";
            String country = "US";
            String urlLocator = "applicationNameUrl_countryCode_env".Replace("applicationName", application).Replace("countryCode", country).Replace("env", testEnvironment);
            // Console.WriteLine("urlLocator: " +  urlLocator);
            String url = Config.Config.urlDictionary[urlLocator];

            return url;
        }

        public void Navigate(String url)
        {
            this.WebDriver.Navigate().GoToUrl(url);

            if ((_browserType == Driver.BrowserType.IE) && this._webDriver.PageSource.Contains("This site is not secure"))
            {
                this._webDriver.FindElement(By.Id("moreInfoContainer")).Click();
                this._webDriver.FindElement(By.Id("overridelink")).Click();
            }

            if ((_browserType == Driver.BrowserType.Edge) && this._webDriver.PageSource.Contains("Your connection isn't private"))
            {
                this._webDriver.FindElement(By.Id("details-button")).Click();
                this._webDriver.FindElement(By.Id("proceed-link")).Click();
            }
        }

        /*public ExtentReports getExtentReports()
        {
        }*/

        public void Pause()
        {
            Thread.Sleep(9999999);
        }
    }
}