using System;
using System.Collections.Generic;
using System.Text;
//using OpenQA.Selenium.Support.PageObjects;
//To use PageFactory add this
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
  public  class HomePage
    {
       
        //public string URL { get; set; } = "http://www.testing.todorvachev.com/";
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How = How.CssSelector,Using = "#page-17 > header > h1")]
        public IWebElement HeadLine { get; set; }

    }
}
