using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace NUnitTest
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new();
#if DEBUG
            Driver = new ChromeDriver(options);
#else
            Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options.ToCapabilities(), commandTimeout: TimeSpan.FromMinutes(5));
#endif
        }
        [TearDown]
        public void QuitDrivers()
        {
            Driver.Quit();
        }
    }
}