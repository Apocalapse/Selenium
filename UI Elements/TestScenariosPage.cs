using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Selenium
{
   public class TestScenariosPage
    {
        public TestScenariosPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.CssSelector,Using = "#main-content > article.mh-loop-item.clearfix.post-72.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-scenarios > div.mh-loop-thumb > a > img")]
        public IWebElement LoginForm { get; set; }
    }
}
