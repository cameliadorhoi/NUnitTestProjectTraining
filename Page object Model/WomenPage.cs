using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjectTraining.Page_object_Model
{
    class WomenPage
    {
        IWebDriver driver;
        private object eyes;

        [SetUp]
        public void initialization()
        {
            driver = new ChromeDriver("C:\\Users\\cameliadorhoi\\source\\repos\\PageObjectModel\\bin\\Debug\\netcoreapp2.1");
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=3&controller=category");
        }

        [Test] // Find an element by name
        public void Test1()
        {
            driver.FindElement(By.Name("layered_category_4")).Click();

        }

        [Test] // Find an element by link text
        public void Test2()
        {
            driver.FindElement(By.LinkText("Contact us")).Click();
        }

    }
}

    
