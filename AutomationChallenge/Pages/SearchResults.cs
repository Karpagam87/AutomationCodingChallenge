using System.Collections.Generic;
using System.Linq;

using OpenQA.Selenium;

using AutomationChallenge.PageObjects;

namespace AutomationChallenge.Pages
{
    public class SearchResults : SearchResultsPage
    {
        public SearchResults(IWebDriver driver) : base(driver)
        {
        }

        public IEnumerable<IWebElement> GetHotelByName(string hotel)
        {
            return GetHotelsByName(hotel);
        }

        public void CloseMapOverlayIfPopUp()
        {
            if (MapOverLayButton.Any())
            {
                MapOverLayButton.First().Click();
            }
        }

        public void SelectFiveStarRating()
        {
            FiveStarRating.Click();
        }

        public void SelectSauna()
        {
            Sauna.Click();
        }
    }
}
