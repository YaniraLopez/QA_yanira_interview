using System;
using OpenQA.Selenium;
using QA_Liverpool.Main;

namespace QA_Liverpool.Screens
{
	public class CreateAccountScreen : Base
	{
		public CreateAccountScreen()
		{
		}
        public IWebElement txtBoxEmail => Driver.FindElement(By.CssSelector("input#email"));
        public IWebElement txtBoxPassword => Driver.FindElement(By.CssSelector("input#password"));
        public IWebElement btnCreate => Driver.FindElement(By.XPath("//button[contains(text(), 'Crear')]"));
	}
}

