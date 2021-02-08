using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
namespace SaveExtractedContentInTextFiles
{
    class EntryPoint
    {
        static void Main()
        {
            List<string> extractedLinks = new List<string>();
            List<string> extractedTitle = new List<string>();
            List<string> extractedContent = new List<string>();

            //IWebDriver driver = new PhantomJSDriver
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");

            IWebDriver driver = new ChromeDriver(options);
            IWebElement titleElement;
            IWebElement contentElement;
            

            string[] pageSource;
            string sitemapURL = "http://testing.todvachev.com/sitemap-posttype-post.xml";
            string titleSelector = "#main-content > article > header > h1";
            string contentSelector = "#main-content > article > div";
            string path = "";

            int startIndex = 0;
            int linkLength = 0;

            driver.Navigate().GoToUrl(sitemapURL);

            string[] pageSource = driver.PageSource.Split(' ');

            foreach (var item in pageSource)
            {

                if (item.Contains("<loc>"))
                {
                    startIndex = item.IndexOf("<loc>") + 5;
                    linkLength = item.IndexOf("<loc>") - startIndex;

                    extractedLinks.Add(item.Substring(startIndex, linkLength));
                    Console.WriteLine(item.Substring(startIndex, linkLength));
                }
            }

            foreach (var item in extractedLinks)
            {
                driver.Navigate().GoToUrl(item);

                titleElement = driver.FindElement(By.CssSelector(titleSelector));
                contentElement = driver.FindElement(By.CssSelector(contentSelector));

                extractedTitle.Add(titleElement.Text);
                extractedContent.Add(contentElement.Text);
            }

            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\ExtractedContent");

            for (int i = 0; i < extractedTitle.Count; i++)
            {
                path = String.Format(Directory.GetCurrentDirectory() + @"\ExtractedContent\0{0} {1}.txt", i, extractedTitle[i]);
                using (StreamWriter sw = File.CreateText(path)
                {
                    sw.WriteLine("TITLE: {0}", extractedTitle[i]);
                    sw.WriteLine("CONTENT:");
                    sw.Write(extractedContent[i]);
                }
            }
        }
    }
}
