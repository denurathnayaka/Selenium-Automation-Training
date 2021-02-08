using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


class SecondPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://testing.todorvachev.com/category/selectors/");
        IWebElement element = driver.FindElement(By.Name("myName"));
        if (element.Displayed)
        {
            System.Console.WriteLine("Yes! I can see the element, it is right there!!!");
        }
        else
        {
            System.Console.WriteLine("Well, somethging went wrong, I couldn't see the element!");
        }
        driver.Quit();
    }
}

