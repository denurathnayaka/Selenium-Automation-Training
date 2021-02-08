using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace SetupPhantomJSProject
{
    class EntryPoint
    {
        static void Main()
        {
            List<string> postLinksList = new List<string>();

            //IWebDriver driver = new PhantomJSDriver
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");

            IWebDriver driver = new ChromeDriver(options);

            string url = @"http://testing.todvachev.com/sitemap-posttype-post.xml";

            driver.Navigate().GoToUrl(url);
            string[] pageSource = driver.PageSource.Split(' ');

            foreach (var item in pageSource)
            {
                Console.WriteLine(item);

                if (item.Contains(@"href=""http://testing.todvachev.com/")) ;
                {
                    postLinksList.Add(item);
                }
            }

        }
    }
}
