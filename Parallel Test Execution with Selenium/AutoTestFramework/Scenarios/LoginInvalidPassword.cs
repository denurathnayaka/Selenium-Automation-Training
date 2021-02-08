﻿using NUnit.Framework;
using OpenQA.Selenium;



namespace AutoTestFramework.Scenarios
{
    [Parallelizable(ParallelScope.None)]
    public class LoginInvalidPassword
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }
        

        public LoginInvalidPassword()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.LoginFormThroughTestCases(Driver);
        }

        [Test]
        public void LessThan5Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.FourCharactors, Config.Credentials.Invalid.Password.FourCharactors, Driver);

            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();

        }

        [Test]
        public void MoreThan12Chars()
        {

            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.ThirteenCharactors, Config.Credentials.Invalid.Password.ThirteenCharactors, Driver);

            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
