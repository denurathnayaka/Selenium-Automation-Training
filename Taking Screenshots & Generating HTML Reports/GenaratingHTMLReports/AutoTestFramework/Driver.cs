using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutoTestFramework
{
   public class Driver
    {
        public static IWebDriver driver = new ChromeDriver();

        internal static void WaitForElementUpTo(int elementsWaitingTimeout)
        {
            throw new NotImplementedException();
        }

        internal static void WaitForElementUpTo(object elementsWaitingTimeout)
        {
            throw new NotImplementedException();
        }
    }
}
