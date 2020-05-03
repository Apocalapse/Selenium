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
    public class Menu
    {
        //const string URL = "http://www.testing.todorvachev.com/";
        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id,Using = "menu-item-25")]
        public IWebElement Introduction { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-106")]
        public IWebElement Selectors { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-35")]
        public IWebElement SpecialElements { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-57")]
        public IWebElement TestCases { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-58")]
        public IWebElement TestScenarios { get; set; }

        [FindsBy(How = How.Id,Using = "menu-item-26")]
        public IWebElement About { get; set; }

    }
}
