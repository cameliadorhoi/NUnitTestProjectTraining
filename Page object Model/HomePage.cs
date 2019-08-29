using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjectTraining.Page_object_Model
{
    public class HomePage
    {
        IWebDriver driver;

        [SetUp] // Navigate to the page
        public void initialization()
        {
            driver = new ChromeDriver("C:\\Users\\cameliadorhoi\\source\\repos\\PageObjectModel\\bin\\Debug\\netcoreapp2.1");
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [Test] // Find element by name 
        public void Test1()
        {
            driver.FindElement(By.Name("search_query")).SendKeys("women");
            driver.FindElement(By.Name("submit_search")).Click();
        }


    }
}
