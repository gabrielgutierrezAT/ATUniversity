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
            driver.Navigate().GoToUrl("https://www.c-sharpcorner.com/register");

            //Fill email
            IWebElement email = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxEmail"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='gabriel@email.com';", email);


            //Fill firstName
            IWebElement firstName = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxFirstName"));
            jse.ExecuteScript("arguments[0].value='Gabriel';", firstName);


            //Fill lastName
            IWebElement lastName = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxLastName"));
            jse.ExecuteScript("arguments[0].value='Gutierrez';", lastName);

            //Fill password
            IWebElement password = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxPassword"));
            jse.ExecuteScript("arguments[0].value='Pass1234';", password);

            //Fill confirmPassword
            IWebElement confirmPassword = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxPasswordConfirm"));
            jse.ExecuteScript("arguments[0].value='Pass1234';", confirmPassword);

            //Select country
            IWebElement country = driver.FindElement(By.Id("ctl00_ContentMain_DropdownListCountry"));
            jse.ExecuteScript("var select = arguments[0]; " + "for (var i=0; i<select.options.length;i++)" + "{ if(select.options[i].text == arguments[1])" + "{ select.options[i].selected = true}}", country, "Mexico");

            //Fill Zip
            IWebElement Zip = driver.FindElement(By.Id("TextBoxZip"));
            jse.ExecuteScript("arguments[0].value='47829';", Zip);

            //Fill city
            IWebElement city = driver.FindElement(By.Id("TextBoxCity"));
            jse.ExecuteScript("arguments[0].value='Ocotlan';", city);

            //Select secQuestion
            IWebElement secQuestion = driver.FindElement(By.Id("ctl00_ContentMain_DropdownListSecurityQuesion"));
            jse.ExecuteScript("var select = arguments[0]; " + "for (var i=0; i<select.options.length;i++)" + "{ if(select.options[i].text == arguments[1])" + "{ select.options[i].selected = true}}", secQuestion, "Where did you vacation last year?");

            //Fill secQuestionAnswer
            IWebElement secQuestionAnswer = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxAnswer"));
            jse.ExecuteScript("arguments[0].value='YES'", secQuestionAnswer);

            /*
             * //check reCaptcha
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(120));
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.CssSelector("#GoolgeReCaptch > div > div > iframe")));
            IWebElement reCaptcha = driver.FindElement(By.Id("recaptcha-anchor"));
            jse.ExecuteScript("arguments[0].click();", reCaptcha);
            driver.SwitchTo().ParentFrame();
            */

            //check impUpdates
            IWebElement impUpdates = driver.FindElement(By.Id("ctl00_ContentMain_CheckBoxNewsletter"));
            jse.ExecuteScript("arguments[0].click();", impUpdates);

            //check acceptTerms
            IWebElement acceptTerms = driver.FindElement(By.Id("cbxIsGDPRAccepted"));
            jse.ExecuteScript("arguments[0].click();", acceptTerms);

            //click register
            IWebElement register = driver.FindElement(By.Id("ctl00_ContentMain_ButtonSave"));
            jse.ExecuteScript("arguments[0].click();", register);


            driver.Quit();

        }



    }
}
