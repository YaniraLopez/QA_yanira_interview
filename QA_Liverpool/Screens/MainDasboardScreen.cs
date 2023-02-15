using OpenQA.Selenium;
using QA_Liverpool.Main;

namespace QA_Liverpool.Screens
{
	public class MainDashboardScreen : Base
	{
		public MainDashboardScreen()
		{
		}

        public IWebElement bottomBanner => Driver.FindElement(By.CssSelector("div.o-mainBanner"));

    }
}

