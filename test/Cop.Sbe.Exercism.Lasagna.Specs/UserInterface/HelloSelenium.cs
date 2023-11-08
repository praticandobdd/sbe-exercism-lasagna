using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using FluentAssertions;

namespace UserInterface;

public class HelloSelenium
{
    [Fact]
    public void ShouldSearchOnGoogle()
    {
        using (var driver = new ChromeDriver()) {
            driver.Navigate().GoToUrl("https://selenium.dev");
            driver.Url = "https://www.google.com";
            driver.FindElement(By.Name("q")).SendKeys("webdriver" + Keys.Return);
            driver.Title.Should().Be("webdriver - Pesquisa Google");
        }
            


    }
}