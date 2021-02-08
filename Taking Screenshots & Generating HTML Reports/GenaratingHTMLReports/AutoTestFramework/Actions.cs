using AutoTestFramework.UIElements;
using OpenQA.Selenium;
using System;



namespace AutoTestFramework
{
    public static class Actions
    {

        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost IsPost = new LoginScenarioPost();

            
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
