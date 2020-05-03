using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Support.UI;


namespace Selenium
{
  public  class NavigateTo
    {
        public static void LoginFromThroughTheMenu()
        {
            Menu menu = new Menu();
            var tsPage = new TestScenariosPage();
            Thread.Sleep(500);
           menu.TestScenarios.Click();
            //menu.Selectors.Click();
            Thread.Sleep(500);
            tsPage.LoginForm.Click();
            Thread.Sleep(500);
        }
        public static void LoginFromThePost()
        {
            Menu menu = new Menu();
            var tcPage = new TestCasesPage();
            var ufPost = new UserNameFieldPost();
            Thread.Sleep(500);
            menu.TestCases.Click();
            Thread.Sleep(500);
            tcPage.UserNameField.Click();
            Thread.Sleep(500);
            ufPost.LoginFormLink.Click();
            Thread.Sleep(500);
        }
    }
}
