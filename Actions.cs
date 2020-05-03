
namespace Selenium
{
    public static class Actions
    {

        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }

        public static void FillLoginForm(string userName, string passWord, string confirmPassword)
        {
            LoginScenarioPost userCredentials = new LoginScenarioPost();
         
            userCredentials.UserName.SendKeys(userName);
            userCredentials.Password.SendKeys(passWord);
            userCredentials.ConfirmPassword.SendKeys(passWord);
            userCredentials.LoginButton.Click();
        }
    }
}

