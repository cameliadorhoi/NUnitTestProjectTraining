using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjectTraining.Page_object_Model
{
    class DressesPage
    {
        IWebDriver driver;
        private object dresses;

        public string Dresses { get; private set; }

        [SetUp]
        public void initialization()
        {
            driver = new ChromeDriver("C:\\Users\\cameliadorhoi\\source\\repos\\PageObjectModel\\bin\\Debug\\netcoreapp2.1");
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        [Test]
        public void Test1()
        {
            //var meniu = driver.FindElement(by);
            //Assert.IsTrue(driver.FindElement(by:.XPath(" ")).isDispayed();

            var meniu = driver.FindElement(By.Id("block_top_menu"));

            Assert.IsNotNull(meniu, "message assert true ce vrei tu ");

        }
        [Test]
        public void Test2()
        {
            var summerCollection = driver.FindElement(By.XPath("//*[@id='htmlcontent_top']/ul/li[2]/a/img"));
            Assert.IsTrue(summerCollection.Displayed, "elementul e afisat");
            

        }

        
    }

}
