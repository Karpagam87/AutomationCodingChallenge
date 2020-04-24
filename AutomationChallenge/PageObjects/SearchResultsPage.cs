using System.Collections.Generic;

using OpenQA.Selenium;

namespace AutomationChallenge.PageObjects
{
    public class SearchResultsPage
    {
        public readonly IWebDriver _driver;

        public SearchResultsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IEnumerable<IWebElement> MapOverLayButton => _driver.FindElements(By.ClassName("map_full_overlay__close"));

        public IWebElement Sauna => _driver.FindElement(By.XPath("//a[@data-id='popular_activities-10']"));

        public IWebElement FiveStarRating => _driver.FindElement(By.XPath("//a[@data-id='class-5']"));

        public IEnumerable<IWebElement> GetHotelsByName(string hotel)
        {
            return _driver.FindElements(By.XPath("//span[contains(@class, 'sr-hotel__name') and contains(text(), '" + hotel + "')]"));
        }
    }
}
