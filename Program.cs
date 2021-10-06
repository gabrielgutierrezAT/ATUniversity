using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_course
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("automation");
            driver.FindElement(By.ClassName("gb_Pe")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div/div[1]/div/div[1]/a")).Click();
            driver.Quit();

        }



    }
}
