using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitTestProjectTraining.Page_object_Model
{
    class ScrollPage
    {
        IWebDriver driver;
        private object eyes;

        [SetUp]
        public void initialization()
        {
            driver = new ChromeDriver("C:\\Users\\cameliadorhoi\\source\\repos\\PageObjectModel\\bin\\Debug\\netcoreapp2.1");
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [Test]
        public void Test1()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("scroll(0,2500)");
            driver.FindElement(By.LinkText("Our stores")).Click();
         
        }

        
        

    }
}

    
