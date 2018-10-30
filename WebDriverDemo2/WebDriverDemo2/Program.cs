using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;

namespace WebDriverDemo2
{
    class Program
    {

        static void Main(string[] args)
        {

            using (IWebDriver driver = new FirefoxDriver(@"C:\Users\Simtlix\Desktop\Drivers"))
            {
                driver.Navigate().GoToUrl("http://www.google.com");
                var searchTextBox = driver.FindElement(By.ClassName("gsfi"));
                searchTextBox.SendKeys("pluralsight");
                var googleSearchButton = driver.FindElement(By.ClassName("lsb"));
                googleSearchButton.Click();
                var imageSearchButton = driver.FindElement(By.XPath("/html/body/div[6]/div[3]/div[5]/div/div/div[1]/div/div/div[1]/div/div[3]/a"));
                imageSearchButton.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                var searchResults = driver.FindElements(By.XPath("//*[@id='rg_s']/div"));

                searchResults[0].Click();
            }
            //driver.Close();



        }


        
    }
}
