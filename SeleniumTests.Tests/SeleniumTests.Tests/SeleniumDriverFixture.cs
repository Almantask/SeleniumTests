using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests.Tests
{
    public class SeleniumDriverFixture:IDisposable
    {
        public IWebDriver Driver { get; }
        const string homeUrl = "http://localhost:52701";
        const string aboutPageUrl = "http://localhost:52701/Home/Contact";

        public SeleniumDriverFixture()
        {
            var dir = Directory.GetCurrentDirectory();

            Driver = new ChromeDriver(dir) { Url = homeUrl };
        }

        public void Dispose()
        {
            Driver.Dispose();
        }

    }
}
