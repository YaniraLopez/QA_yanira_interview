using System;
using OpenQA.Selenium;
using QA_Liverpool.Main;

namespace QA_Liverpool.Screens
{
	public class CommonNavegation : Base
	{
		public CommonNavegation()
		{
		}

        public IWebElement inputSearch => Driver.FindElement(By.CssSelector("input#mainSearchbar"));
        public IWebElement btnSearch => Driver.FindElement(By.CssSelector("div.input-group-append button"));
		public IWebElement linkSignin => Driver.FindElement(By.CssSelector("span.a-header__topLink"));

        public void SearchProductByCategory(string product)
        {
            if (product == "not available")
            {
                Random getRandom = new Random();
                int stringlen = getRandom.Next(4, 15);
                string newStr = "Loremipsum";

                for (int i = 0; i < stringlen; i++)
                {
                    newStr = newStr + Convert.ToChar((getRandom.Next(0, 26)) + 65);
                }
                inputSearch.SendKeys(newStr + Keys.Enter);
            }
            else if (product == "by brand")
            {
                inputSearch.SendKeys("casio" + Keys.Enter);
            }
            else if (product == "by model")
            {
                inputSearch.SendKeys("MacBook Air 13 pulgadas" + Keys.Enter);
            }
            else
            {
                inputSearch.SendKeys("Perfume" + Keys.Enter);
            }
            Thread.Sleep(3000);
        }

        public void SearchProductUsingIconZooom()
        {
            inputSearch.SendKeys("Bolsos");
            btnSearch.Click();
        }
    }
}