using AutoTestFramework.Pages;
using AutoTestFramework.UIElements;
using System;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormScenarioThroughThePost()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameCasePost ucPost = new UsernameCasePost();

            menu.TestCases.Click();
            Thread.Sleep(500);
            tcPage.UsernameCase.Click();
            Thread.Sleep(500);
            ucPost.LoginFormLink.Click();
            Thread.Sleep(500);
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

        public static void LoginFormScenarioThroughMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            Thread.Sleep(500);
            tsPage.LoginFormScenario.Click();
            Thread.Sleep(500);
        }
    }
}
