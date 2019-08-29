using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestProjectTraining.Page_object_Model
{
    class Test11_17aug
    {
        IWebDriver driver;

        [SetUp]
        public void initialization()
        {
            driver = new ChromeDriver("C:\\Users\\cameliadorhoi\\source\\repos\\PageObjectModel\\bin\\Debug\\netcoreapp2.1");
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_product=1&controller=product");

        }

        [Test]
        public void Test1()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10);

            var group_1 = driver.FindElement(By.Id("group_1"));
            var select_group_1 = new SelectElement(group_1);
            select_group_1.SelectByValue("3");

  
        }

  

    }

}
