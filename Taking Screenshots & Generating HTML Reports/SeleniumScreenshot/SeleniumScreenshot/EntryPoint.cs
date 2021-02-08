using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

class EntryPoint
{
    static void Main()
    {
        IWebDriver chrome = new ChromeDriver();

        chrome.Navigate().GoToUrl("http://google.com");

        Screenshot googleScreenshot = ((ITakesScreenshot)chrome).GetScreenshot();

        Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshots");

        googleScreenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\googlescreenshot.png", ScreenshotImageFormat.Png);

        chrome.Quit();

    }
}

