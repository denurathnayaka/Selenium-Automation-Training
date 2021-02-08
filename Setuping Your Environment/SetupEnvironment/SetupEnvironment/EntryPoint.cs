using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
    {
        static void Main()
        {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://testing.todorvachev.com/");
        Thread.Sleep(10000);
        driver.Quit();
        }
    }


