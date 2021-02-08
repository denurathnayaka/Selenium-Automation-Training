using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;

class EntryPoint
{
    static void Main()
    {
        List<string> handles = new List<string>();

        IWebDriver driver = new ChromeDriver();
        IWebElement newTab;
        IWebElement newWindow;

        string url = "http://testing.todvachev.com/tabs-and-windows/new-tab/";
        string newTabSelector = "#post-182 > div > p:nth-child(1) > a:nth-child(1)";
        string newWindowSelector = "post-182 > div > p:nth-child(1) . a:nth-child(3)";

        driver.Navigate().GoToUrl(url);

        newTab = driver.FindElement(By.CssSelector(newTabSelector));
        newWindow = driver.FindElement(By.CssSelector(newWindowSelector));

        newTab.Click();

        handles = driver.WindowHandles.ToList();

        for (int i = 0; i < handles.Count; i++)
        {
            System.Console.WriteLine(handles[i]);
        }

        IWebElement usernameBox = driver.FindElement(By.Name("username"));
        usernameBox.SendKeys("Selenium");

        System.Console.WriteLine(driver.CurrentWindowHandle);
        driver.SwitchTo().Window(handles[1]);
        System.Console.WriteLine(driver.CurrentWindowHandle);

        IWebElement searchBox = driver.FindElement(By.Name("q"));
        searchBox.SendKeys("Selenium");
    }
}

