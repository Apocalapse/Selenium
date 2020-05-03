

namespace Selenium
{
   public static class Config
    {
        public static string BaseURL = "http://testing.todorvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "JohnDoe";
                public static string Password = "Password1234";
                public static string ConfirmPassword = "Password1234";
                public static string Email = "example@example.com";

            }

            public static class Invalid
            {
                public static string FourCharacters = "ADSL";
                public static string ThirteenCharacters = "Password12345";
            }

        }
        public static class AlertMessages
        {
            public static string SuccessfulLogin = "Successful Login!";
        }
    }
}
