using NUnit.Framework;
using OpenQA.Selenium;


namespace AutoTestFramework
{
    public class EntryPoint
    {
        IAlert alert;
        static void Main()
        {
            
        }
        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillLoginForm((string)Config.Credentials.Valid.Username, (string)Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);

            alert.Accept();

        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
