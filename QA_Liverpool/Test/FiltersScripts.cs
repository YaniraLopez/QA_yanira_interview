using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QA_Liverpool.Screens;
using QA_Liverpool.Main;

namespace QA_Liverpool.Test
{
	public class FiltersScripts : Base
	{
        Filters filters = new Filters();
        SearchResultScreen searchResultScreen = new SearchResultScreen();
        CommonNavegation common = new CommonNavegation();

        public FiltersScripts()
		{
		}

        [Test]
        public void Filters_Validate_Prices_Range_Setting_Values()
        {
            //search a product out of the stock
            common.SearchProductByCategory("any");
            int resultsBeforeFilters = Convert.ToInt32(searchResultScreen.lblTotResults.Text);

            //set range of prices
            filters.setRangeOfPrices();
            filters.btnaAplyFilters.Click();
            Thread.Sleep(3000);
            int resultsAfterFilters = Convert.ToInt32(searchResultScreen.lblTotResults.Text);

            //Validate if the caunter results change after apply the filter
            Assert.IsTrue(resultsBeforeFilters != resultsAfterFilters);
        }
    }
}

