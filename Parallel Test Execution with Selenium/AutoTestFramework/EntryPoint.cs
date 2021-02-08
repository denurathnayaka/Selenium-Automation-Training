using NUnit.Framework;
using OpenQA.Selenium;


namespace AutoTestFramework
{
    public class EntryPoint
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }
        static void Main()
        {
            
        }
        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidLogin(IWebDriver driver)
        {
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillLoginForm((string)Config.Credentials.Valid.Username, (string)Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, Driver);

            alert = driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);

            alert.Accept();

        }

        [TearDown]
        public void CleanUp(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}
