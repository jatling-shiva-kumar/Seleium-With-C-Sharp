namespace selenium_Test;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class seleninTest
{
[Test]
// [Category("Ekalavya")]
public void FirstTest(){
    IWebDriver driver = new ChromeDriver();
    driver.Manage().Window.Maximize();
    driver.Navigate().GoToUrl("https://ekalavya.online/admin.html");
    // Assert.That(driver.Title,Is.EqualTo("Ekalavya"));   

}

}
