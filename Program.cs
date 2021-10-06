using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;

namespace Selenium_course
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //ImplicitWait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Automation with C#" + Keys.Enter);
            
            //Explicit Waits
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 1));
            var implicitwait = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div.yuRUbf")));

            _ = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Name("q")));

            //Get Elements into a Collection
            ReadOnlyCollection<IWebElement> results = driver.FindElements(By.CssSelector("div.yuRUbf > a > h3"));

            //Print Items on Collection
            foreach (IWebElement element in results)
            {
                Console.WriteLine(element.Text);
            }

            Console.WriteLine();

            driver.Quit();

        }


    }
}
