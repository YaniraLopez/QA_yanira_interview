using OpenQA.Selenium;
using System.Reflection.Metadata;
using OpenQA.Selenium.Support.UI;
using QA_Liverpool.Screens;
using QA_Liverpool.Main;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Xml.Linq;

namespace QA_Liverpool.Test
{
    [TestFixture]
    [Parallelizable]
    public class SearchBarScripts : Base
    {
        CommonNavegation common = new CommonNavegation();
        ProductDetails productDetails = new ProductDetails();
        SearchResultScreen searchResultScreen = new SearchResultScreen();
        public static WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));

        public SearchBarScripts()
        {
        }

        [Test]
        public void Search_Bar_Open_Product_From_Result_List()
        {
            //search product name
            common.SearchProductUsingIconZooom();
            //Open any result
            wait.Until(d => searchResultScreen.txtBoxDropDown);//wait until element is visible
            searchResultScreen.SelectResult();
            wait.Until(d => productDetails.btnAddtoCart);
            //Validate if we can see the product details
            Assert.IsTrue(productDetails.btnAddtoCart.Displayed);
        }

        [Test]
        public void Search_Bar_Not_Found_Message()
        {
            //search a product out of the stock
            common.SearchProductByCategory("not available");
            //Validate if we redirect to no results screen
            Assert.IsTrue(searchResultScreen.searchAdvice.Displayed);
        }
    }
}
