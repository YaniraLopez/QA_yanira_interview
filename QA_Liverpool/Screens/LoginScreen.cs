using System;
using OpenQA.Selenium;
using QA_Liverpool.Main;

namespace QA_Liverpool.Screens
{
	public class LoginScreen : Base
	{
		public LoginScreen()
		{
		}

        public IWebElement linkCreateAccount => Driver.FindElement(By.XPath("//*[contains(text(), 'Crear cuenta')]"));
    }
}

