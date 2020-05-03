
//Add Directives
//using Amazon.DynamoDBv2;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
//For using drop down list
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Selenium
{

    public class EntryPoint
    {

        #region Lessons Code
        private const string URLS = "http://testing.todorvachev.com/selectors/";
        private const string URL_SPECIAL_ELEMENTS = "http://testing.todorvachev.com/special-elements/";
        static IWebDriver drivers = new ChromeDriver();
        static bool success = false;
        
        //Alert Box
        static IAlert alertBox;

        #endregion
        //ctrl + k + d use to format your code
        // NuGet Selenium Web Driver
        // Selenium Support


        static void Main()
        {

            //  Lesson1("http://testing.todorvachev.com/");
            //  Lesson2("URLS + "name/");
            //   Lesson3IDSelector("URLS + "id/");
            //  Lesson4ClassName(URLS + "class-name/");
            // LessonCssAndXPath(URLS + "css-path/");
            // SpecialElementsTextInput(URL_SPECIAL_ELEMENTS + "text-input-field/");
            // SpecialElementsCheckButton(URL_SPECIAL_ELEMENTS + "check-button-test-3/");
            //  SpecialElementsRadioButton(URL_SPECIAL_ELEMENTS + "radio-button-test/");
            //  SpecialElementsDropDownList(URL_SPECIAL_ELEMENTS + "drop-down-menu-test/");
            //   SpecialElementAlertBox(URL_SPECIAL_ELEMENTS + "alert-box/");

            // TestingHomePage();

            try
            {
                //TestScenarios();
                // Driver.driver.Navigate().GoToUrl(Config.BaseURL);
               TestingLoginForms();
               
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
             
            }
            finally
            {
                Driver.driver.Close();
            }




            // var menu = new Menu();
            //   menu.Introduction = Driver.driver.FindElement(By.Id(menu.Introduction.));


        }

       [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver(); 
        }
       [Test]
        public void ValidLogin()
        {
            TestingLoginForms();
        }


       [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

       public static void TestingLoginForms()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
           // Driver.driver.Manage().Window.Maximize();
            NavigateTo.LoginFromThroughTheMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.ConfirmPassword);
            alertBox = Driver.driver.SwitchTo().Alert();
            //alertBox.Accept();
          //  Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alertBox.Text);
            alertBox.Accept();
        }

        private static void TestScenarios()
        {
           // Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            //    driver.Manage().Window.Maximize();





            //menu.TestScenarios.Click();
            // LoginFromThroughTheMenu();
            #region Login Through The Menu
            // NavigateTo.LoginFromThroughTheMenu();
            //  Driver.driver.Navigate().GoToUrl(Config.BaseURL);

            //NavigateTo.LoginFromThePost();
            //Thread.Sleep(3000);
            #endregion

           


        }

        private static void LoginFromThroughTheMenu()
        {
          //  driver.Navigate().GoToUrl(Config.BaseURL);
            // driver.Manage().Window.Maximize();
            Thread.Sleep(4000);

            NavigateTo.LoginFromThroughTheMenu();
            Thread.Sleep(500);
        }
        private static bool TestingHomePage()
        {
            HomePage homePage = new HomePage();
            Driver.driver.Navigate().GoToUrl("http://testing.todorvachev.com/");

            Driver.driver.Manage().Window.Maximize();

            try
            {
                success = Validate_HomePage(homePage);

                if (success == true)
                {
                    Console.WriteLine("{0} The Homepage has been found", success);
                    SelectorsClick();
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("{0} No Element found cannot use it", success);
            }

            drivers.Quit();
            return success;
        }

        /// <summary>
        /// Click the Selector Menu
        /// </summary>
        public static void SelectorsClick()
        {
            var menu = new Menu();
          //  if(menu.Selectors.Displayed)
            menu.Selectors.Click();            
        }
        public static bool Validate_HomePage(HomePage homePage)
        {
            Thread.Sleep(5000);
           if( homePage.HeadLine.Displayed)
            {
                return true;
            }
                return false;
        }

        /// <summary>
        /// Working with Alert Boxes
        /// </summary>
        /// <param name="url"></param>
        private static void SpecialElementAlertBox(string url)
        {
            try
            {
                drivers.Navigate().GoToUrl(url);

                alertBox = drivers.SwitchTo().Alert();
                Console.WriteLine(alertBox.Text);

                // alertBox.Accept();

                IWebElement imageElement = drivers.FindElement(By.CssSelector("#post-119 > div > figure > img"));

                if (imageElement.Displayed == true)
                {
                    GreenMessage("Element is found");
                }


            }
            catch (NoSuchElementException)
            {

                RedMessage("Element was not found");
            }
            drivers.Close();
        }

        /// <summary>
        /// Working with Drop Down list
        /// </summary>
        /// <param name="url"></param>
        private static void SpecialElementsDropDownList(string url)
        {
            try
            {
                drivers.Navigate().GoToUrl(url);
                drivers.Manage().Window.Maximize();

                var dropDownElement = drivers.FindElement(By.Name("DropDownTest"));

                var dropDown = new SelectElement(dropDownElement);
                var currentDropDownValue = dropDownElement.GetAttribute("value");

                Console.WriteLine(currentDropDownValue);
                dropDown.SelectByIndex(2);
                Console.WriteLine(dropDownElement.GetAttribute("value"));
                drivers.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Working with RadioButtons
        /// </summary>
        /// <param name="url"></param>
        private static void SpecialElementsRadioButton(string url)
        {
            try
            {
                drivers.Navigate().GoToUrl(url);
                int[] options = { 1, 3, 5 };
                drivers.Manage().Window.Maximize();
                IWebElement rbMale = drivers.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + options[0] + ")"));
                IWebElement rbFemale = drivers.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + options[1] + ")"));
                IWebElement rbOther = drivers.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + options[2] + ")"));

                if (rbMale.GetAttribute("checked") == "true")
                {
                    Console.WriteLine("This radio button is checked");
                }
                else
                {
                    Console.WriteLine("This one of the radio buttons that have not been checked");
                }
                //chkMale.Clear();
                rbOther.Click();
                drivers.Close();

            }
            catch (Exception ex)
            {

                throw new NoSuchElementException("Element not Found Exception. The error message is " + ex.Message );
            }
        }

        /// <summary>
        /// Working with Check Boxes
        /// </summary>
        /// <param name="v"></param>
        private static void SpecialElementsCheckButton(string url)
        {
            drivers.Navigate().GoToUrl(url);
            try
            {
                IWebElement chkButton = drivers.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(1)"));
                if (chkButton.GetAttribute("checked") == null)
                {
                    GreenMessage("The first checkbox has been checked");
                }
                else
                {
                    GreenMessage("The first checkbox has not been checked");
                }

                // chkButton.GetAttribute("value");
                chkButton.Click();
                chkButton.Click();

                string chkBox1 = chkButton.GetAttribute("value");
                IWebElement chkButton2 = drivers.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(3)"));
                string chkBox2 = chkButton2.GetAttribute("value");
                Console.WriteLine("Check Box 1 has a value: {0}", chkBox1);
                Console.WriteLine("Check Box 2 has a value: {0}", chkBox2);

                drivers.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }
        /// <summary>
        /// Working with Text Boxes
        /// </summary>
        /// <param name="url"></param>
        private static void SpecialElementsTextInput(string url)
        {
            drivers.Navigate().GoToUrl(url);

            try
            {
                IWebElement webElement = drivers.FindElement(By.Name("username"));

                webElement.SendKeys("Hello World!");
                //return the value of the textbox
                Console.WriteLine(webElement.GetAttribute("value"));

                string MAXLENGTH = webElement.GetAttribute("maxlength");
                Console.WriteLine(MAXLENGTH);
                Thread.Sleep(3000);

                webElement.Clear();
            }
            catch (Exception ex)
            {

                throw new NoSuchElementException("No Such Element Found " + ex.Message);
            }

        }

        /// <summary>
        /// Uses CssSelectors and XPath
        /// </summary>
        /// <param name="v"></param>
        private static void LessonCssAndXPath(string v)
        {
            // IWebDriver driver = new ChromeDriver();
            drivers.Navigate().GoToUrl(v);
            //cssSelectors are faster than xPath
            const string CSSPATH = "#post-108 > div > figure > img";
            const string XPATH = "//*[@id=\"post-108\"]/div/figure/img";
            bool useCssPath = true;
            IWebElement webElement = null;

            try
            {
                if (useCssPath == true)
                {
                    webElement = drivers.FindElement(By.CssSelector(CSSPATH));
                }
                else
                {
                    webElement = drivers.FindElement(By.XPath(XPATH));
                }
                FindElement(webElement);

            }
            catch (NoSuchElementException)
            {
                FindElement(webElement);
            }
            finally
            {
                drivers.Close();
            }

        }

        /// <summary>
        /// Uses Class Name Selector
        /// </summary>
        /// <param name="url"></param>
        private static void Lesson4ClassName(string url)
        {
            drivers.Navigate().GoToUrl(url);

            IWebElement webElement = drivers.FindElement(By.ClassName("testClass"));

            FindElement(webElement);

            Console.WriteLine(webElement.Text);

            drivers.Close();
        }

        /// <summary>
        /// Uses Id Selector 
        /// </summary>
        /// <param name="url"></param>
        private static void Lesson3IDSelector(string url)
        {
            drivers.Navigate().GoToUrl(url);

            IWebElement idElement = drivers.FindElement(By.Id("testImage"));

            FindElement(idElement);

            drivers.Close();


        }
        /// <summary>
        /// Find by Name
        /// </summary>
        /// <param name="Url"></param>
        public static void Lesson2(string Url)
        {
            drivers.Navigate().GoToUrl(Url);

            IWebElement element = drivers.FindElement(By.Name("myName"));

            FindElement(element);
            drivers.Quit();
        }


        /// <summary>
        /// Displays output if element is found
        /// </summary>
        /// <param name="element"></param>
        private static void FindElement(IWebElement element)
        {
            if (element.Displayed == true)
            {
                Thread.Sleep(3000);
                GreenMessage("Now You See Me. Element FOUND!");
            }
            else
            {
                Thread.Sleep(3000);
                RedMessage("Now You Don't. Element NOT FOUND!");
            }
        }

        private static void GreenMessage(string print)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(print);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void RedMessage(string print)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(print);
        }


        public static void Lesson1(string Url)
        {
            drivers.Navigate().GoToUrl(Url);

            Thread.Sleep(3000);
            drivers.Close();
        }       
    }
}

