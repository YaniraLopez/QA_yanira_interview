using System;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using QA_Liverpool.Main;

namespace QA_Liverpool.Screens
{
	public class SearchResultScreen : Base
	{
		public SearchResultScreen()
		{
		}

        public IWebElement txtBoxDropDown => Driver.FindElement(By.CssSelector("div.col-lg-4 div.m-dropdown"));
        public IWebElement searchAdvice => Driver.FindElement(By.CssSelector("div.o-content__noResultsNullSearch"));
        public static IReadOnlyList<IWebElement> Results_Option => Driver.FindElements(By.CssSelector("li.m-product__card.card-masonry"));
        public static IReadOnlyList<IWebElement> Results_Image => Driver.FindElements(By.CssSelector("section.section_img_size"));
        public IWebElement lblTotResults => Driver.FindElement(By.CssSelector("p.a-plp-results-title span"));

        public void SelectResult()
        {
            Random random_option = new Random();

            if (txtBoxDropDown.Displayed == true)
            {
                int item = random_option.Next(Results_Option.Count);

                for (int i = 0; i < Results_Option.Count; i++)
                {
                    if (i == item)
                    {
                        scrollToElement(Results_Option[i]);
                        WaitForElement(Results_Image[i]);
                        Results_Image[i].Click();
                        break;
                    }
                }
            }
            else
                Console.WriteLine("Not found elements");
        }
    }
}

