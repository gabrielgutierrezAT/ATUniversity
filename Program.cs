using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace Selenium_course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 
            IWebDriver driver = new ChromeDriver();
             driver.Navigate().GoToUrl("http://demoqa.com/checkbox");
             driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all > svg")).Click();
             driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(2) > span > label > span.rct-checkbox > svg")).Click();
             driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(3) > span > label > span.rct-checkbox > svg")).Click();
             Thread.Sleep(5000);

            //Exercise 2          
            driver.Navigate().GoToUrl("http://demoqa.com/radio-button");
            IWebElement yesradio = driver.FindElement(By.Id("yesRadio"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].click()", yesradio);
            Thread.Sleep(2000);
            IWebElement impressiveRadio = driver.FindElement(By.Id("impressiveRadio"));
            jse.ExecuteScript("arguments[0].click()", impressiveRadio);
            Thread.Sleep(5000);


            //Exercise 3
            driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            IWebElement elemtable = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div[3]/div[1]/div[2]"));
            List<IWebElement> lstTrElem = new List<IWebElement>(elemtable.FindElements(By.ClassName("rt-td")));
            foreach (var elemTd in lstTrElem) {
                if (elemTd.Text != "" && elemTd.Text.Contains("@"))
                {
                    Console.WriteLine(elemTd.Text);
                }
            }
            Thread.Sleep(5000);


            //Exercise 4
            driver.Navigate().GoToUrl("http://demoqa.com/select-menu");
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            var implicitwait = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("withOptGroup")));

            //1st DDL 
            Actions actionddl1 = new Actions(driver);
            IWebElement ddl1 = driver.FindElement(By.Id("withOptGroup"));
            actionddl1.MoveToElement(ddl1).Click().Perform();
            actionddl1.MoveToElement(ddl1).SendKeys("Group 1, option 2" + Keys.Enter).Perform();
            Thread.Sleep(2000);

            //2nd DDL
            Actions actionddl2 = new Actions(driver);
            IWebElement ddl2 = driver.FindElement(By.Id("selectOne"));
            actionddl2.MoveToElement(ddl2).Click().Perform();
            actionddl2.MoveToElement(ddl2).SendKeys("Mr." + Keys.Enter).Perform();
            Thread.Sleep(2000);
            
            //3rd DDL
            SelectElement ddl3 = new SelectElement(driver.FindElement(By.Id("oldSelectMenu")));
            ddl3.SelectByIndex(1);
            Thread.Sleep(2000);

            //4th DDL
            Actions actionddl4 = new Actions(driver);
            IWebElement ddl4 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div[7]/div/div/div/div[1]/div[1]"));
            actionddl4.MoveToElement(ddl4).Click().Perform();
            actionddl4.MoveToElement(ddl4).SendKeys("Blue" + Keys.Enter).Perform();
            Thread.Sleep(2000);
            
            //5th DDL
            SelectElement ddl5 = new SelectElement(driver.FindElement(By.Id("cars")));
            ddl5.SelectByIndex(1);
            Thread.Sleep(5000);


            driver.Quit();












        }



}
}
