namespace AutoTestFramework.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    public class SpecialElementsPage
    {
        public SpecialElementsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

    }
}
