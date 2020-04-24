using System.Collections.Generic;
using System.Linq;

using OpenQA.Selenium;

using AutomationChallenge.PageObjects;

namespace AutomationChallenge.Pages
{
    /// <summary>
    /// class for search results page
    /// </summary>
    public class SearchResults : SearchResultsPage
    {
        /// <summary>
        /// constructor for <see cref="SearchResultsPage"/>
        /// </summary>
        /// <param name="driver">webdriver</param>
        public SearchResults(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// To get the list of hotel names
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        public IEnumerable<IWebElement> GetHotelByName(string hotel)
        {
            return GetHotelsByName(hotel);
        }

        /// <summary>
        /// To close the pop up overlay that occurs occasionally
        /// </summary>
        public void CloseMapOverlayIfPopUp()
        {
            if (MapOverLayButton.Any())
            {
                MapOverLayButton.First().Click();
            }
        }

        /// <summary>
        /// To select the star rating filter
        /// </summary>
        public void SelectFiveStarRating()
        {
            FiveStarRating.Click();
        }

        /// <summary>
        /// To select the spa/wellness filter
        /// </summary>
        public void SelectSauna()
        {
            Sauna.Click();
        }
    }
}
