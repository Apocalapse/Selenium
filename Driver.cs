using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
  public static  class Driver
    {
        public static IWebDriver driver = new ChromeDriver(@"C:\BrowserNodes\");
    }
}
