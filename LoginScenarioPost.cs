using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Selenium
{ 

    public class LoginScenarioPost
    {
        public LoginScenarioPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//input[@name='userid']")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name,Using = "passid")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name,Using = "repeatpassid")]
        public IWebElement ConfirmPassword { get; set; }

        [FindsBy(How = How.XPath,Using = "//input[@value='LOGIN']")]
        public IWebElement LoginButton { get; set; }

        
       
    }
}