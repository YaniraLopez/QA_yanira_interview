using System;
using OpenQA.Selenium;
using QA_Liverpool.Main;

namespace QA_Liverpool.Screens
{
	public class Filters : Base
	{
		public Filters()
		{
		}
        public IWebElement txtBoxMaxPrice=> Driver.FindElement(By.CssSelector("input#max-price-filter"));
        public IWebElement txtBoxMinPrice=> Driver.FindElement(By.CssSelector("input#min-price-filter"));
        public IWebElement btnaAplyFilters => Driver.FindElement(By.CssSelector("div.a-price__filterButton"));


        public void setRangeOfPrices()
		{
            Random random = new Random();

            string min_amount = Convert.ToString(random.Next(200, 500));
            string max_amount = Convert.ToString(random.Next(2500, 4000));
            txtBoxMinPrice.SendKeys(min_amount);
            txtBoxMaxPrice.SendKeys(max_amount);
        }
    }
}

