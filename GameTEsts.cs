using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class GameTests
{
    private IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        // Set up the WebDriver (ChromeDriver in this case)
        driver = new ChromeDriver();
    }

    [Test]
    public void TestGame()
    {
        // Navigate to your HTML game URL
        driver.Navigate().GoToUrl("file:///path/to/your/game.html");

        // Example: Enter player name and score for Battle 1
        driver.FindElement(By.Id("playerName1")).SendKeys("Player1");
        driver.FindElement(By.Id("battleScore1")).SendKeys("50");

        // Example: Enter player name and option for Battle 2
        driver.FindElement(By.Id("playerName2")).SendKeys("Player2");
        new SelectElement(driver.FindElement(By.Id("battleOption2"))).SelectByText("Attack");

        // Submit the form
        driver.FindElement(By.CssSelector("button[type='submit']")).Click();

        // Add assertions or additional interactions as needed

        // Sleep to see the result (you can replace this with proper waits)
        System.Threading.Thread.Sleep(3000);
    }

    [TearDown]
    public void TearDown()
    {
        // Close the browser after the test
        driver.Quit();
    }
}
