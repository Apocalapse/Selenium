using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Selenium
{
    public class UserNameFieldPost
    {
        public UserNameFieldPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath,Using = "//*[text() = 'Login form']")]
        public IWebElement LoginFormLink { get; set; }
    }
}