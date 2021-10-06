using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium_course
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("ok" + Keys.Enter);
            driver.Quit();

        }


    }
}
