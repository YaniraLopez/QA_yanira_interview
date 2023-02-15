using System;
using System;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using QA_Liverpool.Main;

namespace QA_Liverpool.Screens
{
	public class ProductDetails:Base
	{
		public ProductDetails()
		{
		}

        public IWebElement btnBuyNow => Driver.FindElement(By.CssSelector("button#opc_pdp_buyNowButton"));
        public IWebElement btnAddtoCart => Driver.FindElement(By.CssSelector("button#opc_pdp_addCartButton"));

        public void AddToCart()
        {
            btnAddtoCart.Click();
        }
    }
}

