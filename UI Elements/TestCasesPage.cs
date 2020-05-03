using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Selenium
{
    internal class TestCasesPage
    {
        public TestCasesPage()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How = How.CssSelector,Using  = "#main-content > article.mh-loop-item.clearfix.post-74.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div.mh-loop-thumb > a > img")]
        public IWebElement UserNameField { get; set; }
    }
}