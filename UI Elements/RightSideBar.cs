﻿using System;
using System.Collections.Generic;
using System.Text;
//To use PageFactory add this
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class RightSideBar
    {

      //  public string URL { get; set; } = "http://www.testing.todorvachev.com/";
        public RightSideBar()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "#page-17 > header > h1")]
        public IWebElement HeadLine { get; set; }
    }
}
