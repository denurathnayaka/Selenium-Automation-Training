using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new InternetExplorerDriver();

        System.Console.WriteLine(driver.GetType().ToString());
        System.Console.WriteLine(driver.GetType().ToString());

        if (driver.GetType().ToString().Contains("InternetExplorerDriver"))
        {
            driver.Navigate().GoToUrl("http://google.com");
        }
        else if (driver.GetType().ToString().Contains("Chrome"))
        {
            driver.Navigate().GoToUrl("http://gmail.com");
        }


    }
}

