using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void TitleValidation()
        {            
            driver.Navigate().GoToUrl("http://www.nba.com");
            string title = driver.Title;
            Assert.That(title, Is.EqualTo("NBA.com México | El sitio oficial de la NBA"));

        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}