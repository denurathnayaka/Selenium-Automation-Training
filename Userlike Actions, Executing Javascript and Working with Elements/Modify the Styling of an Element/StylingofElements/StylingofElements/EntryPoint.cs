using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        string url = "http://testing.todvachev.com";

        driver.Navigate().GoToUrl(url);

        IWebElement image = driver.FindElement(By.CssSelector("#page-17 > div"));

        //driver.Manage().Window.Maximize();

        //Console.WriteLine(image.Location.X);
        //Console.WriteLine(image.Location.Y);
        //Console.WriteLine(image.Size.Width);
        //Console.WriteLine(image.Size.Height);

        SetStyle(driver, content, "color", "green");
    }
    static void SetStyle(IWebDriver driver, IWebElement element, string style, string styleValue)
    {

        string script = String.Format("arguments[0].style[\"{0}\"] = \"{1}\"", style, styleValue);
        IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


        jsExecutor.ExecuteScript(script, element);

    }


}