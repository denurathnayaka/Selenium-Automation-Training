using AutoTestFramework.UIElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;



namespace AutoTestFramework
{
    public static class Actions
    {

        public static IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }

        public static void FillLoginForm(string username, string password, string repeatPassword, IWebDriver driver)
        {
            LoginScenarioPost IsPost = new LoginScenarioPost(driver);

            
            IsPost.UsernameField.SendKeys(username);
            IsPost.PasswordField.SendKeys(password);
            IsPost.RepeatPasswordField.SendKeys(repeatPassword);
            IsPost.LoginButton.Click();
        }

        internal static void FillLoginForm(object fourCharactors, object password1, object password2, IWebDriver driver)
        {
            throw new NotImplementedException();
        }

    }
}
