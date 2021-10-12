 
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
            driver.Navigate().GoToUrl("http://www.nba.com");
            String title = driver.Title;
            Console.WriteLine("Page Title is: " + title);
            driver.Quit();

        }



    }
}