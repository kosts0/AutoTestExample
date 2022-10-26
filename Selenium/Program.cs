using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;



ChromeOptions options = new ChromeOptions();
options.AddArgument("enableVNC: true");
var chromeOptionsDictionary = new Dictionary<string, object>
{
    { "enableVNC", true }
};
Proxy proxy = new Proxy();
proxy.Kind = ProxyKind.Manual;
proxy.HttpProxy = proxy.SslProxy = "89.38.96.219:3128";
options.Proxy = proxy;
options.AddAdditionalOption("selenoid:options", chromeOptionsDictionary);
options.AcceptInsecureCertificates = true;
IWebDriver Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options.ToCapabilities(), commandTimeout: TimeSpan.FromMinutes(5));
Driver.Navigate().GoToUrl("https://www.google.com");
Driver.Quit();