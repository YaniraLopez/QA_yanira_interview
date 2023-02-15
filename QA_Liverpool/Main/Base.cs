using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QA_Liverpool.Screens;
using System.Xml.Linq;

namespace QA_Liverpool.Main
{
	public class Base
	{
        public static IWebDriver Driver;

        public Base()
        {
        }

        [SetUp]
        public void Open()
        {
            //Star the browser
            Driver = new ChromeDriver();
            OpenStoreMainPage();
        }

        [TearDown]
        public void Close()
        {
            Driver.Quit();
        }

        public void OpenStoreMainPage()
        {
            //Maximize browser
            Driver.Manage().Window.Maximize();
            //Navigate into webpage
            Driver.Navigate().GoToUrl("https://www.liverpool.com.mx/tienda/home");
        }

        public void scrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
        }

        public void WaitForElement(IWebElement element, int waitTime = 3000, String message = "")
        {
            var _load = false;
            var _count = 0;
            while (!_load && _count < 20)
            {
                try
                {
                    _load = element.Displayed;
                }
                catch (NoSuchElementException ex)
                {
                    _load = false;
                }
                if (_load == false)
                {
                    _count++;
                    Thread.Sleep(waitTime / 10);
                }
            }
            if (!_load)
            {
                if (message == null)
                    Assert.IsTrue(false, "Element Not Found : " + element);
                else
                    Assert.Fail(message);
            }
        }
    }
}