using AutoTestFramework.Pages;
using AutoTestFramework.UIElements;
using System;
using SeleniumExtras.PageObjects;
using System.Threading;
using OpenQA.Selenium;

namespace AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormScenarioThroughThePost(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCasesPage tcPage = new TestCasesPage(driver);
            UsernameCasePost ucPost = new UsernameCasePost(driver);

            menu.TestCases.Click();
            Thread.Sleep(500);
            tcPage.UsernameCase.Click();
            Thread.Sleep(500);
            ucPost.LoginFormLink.Click();
            Thread.Sleep(500);
        }

        internal static void LoginFormThroughTestCases(IWebDriver driver)
        {
            throw new NotImplementedException();
        }

        internal static void LoginScenarioPostThroughTestCases()
        {
            throw new NotImplementedException();
        }

        internal static void LoginFormScenarioThroughTestCases()
        {
            throw new NotImplementedException();
        }

        internal static void LoginFormThroughThePost()
        {
            throw new NotImplementedException();
        }

        internal static void LoginFormThroughTheMenu()
        {
            throw new NotImplementedException();
        }

        public static void LoginFormScenarioThroughMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestScenariosPage tsPage = new TestScenariosPage(driver);

            menu.TestScenarios.Click();
            Thread.Sleep(500);
            tsPage.LoginFormScenario.Click();
            Thread.Sleep(500);
        }
    }
}
