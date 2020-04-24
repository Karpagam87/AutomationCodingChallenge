using System;
using System.Linq;

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

using AutomationChallenge.Pages;

namespace AutomationChallenge
{
    [TestFixture]
    public class RatingAndSaunaScenerios
    {
        private string _fromData;
        private string _toDate;
        private IWebDriver _driver;
        private Home _home;
        private SearchResults _searchResults;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.booking.com/");

            _home = new Home(_driver);
            _searchResults = new SearchResults(_driver);

            _fromData = DateTime.Now.AddMonths(3).ToString("yyyy-MM-dd");
            _toDate = DateTime.Now.AddMonths(3).AddDays(1).ToString("yyyy-MM-dd");
        }

        [Test, Category("Rating tests")]
        [TestCase("Limerick", "Limerick City Centre", "The Savoy Hotel", true, 2, 1)]
        [TestCase("Limerick", "Limerick City Centre", "George Limerick Hotel", false, 2, 1)]
        [TestCase("Limerick", "Limerick City Centre", "George Limerick Hotel", false, 3, 2)]
        [TestCase("Limerick", "Limerick City Centre", "The Savoy Hotel", true, 25, 20)]
        public void Validate_FiveStarHotelList(string search, string destination, string hotelName, bool exists, int adults, int rooms)
        {
            SearchCriteriaInHome(search, destination, adults, rooms);
            _searchResults.SelectFiveStarRating();
            WebDriverUtility.SleepForThreeSeconds();

            var hotel = _searchResults.GetHotelByName(hotelName);

            Assert.AreEqual(exists, hotel.Any());            
        }

        [Test, Category("Sauna tests")]
        [TestCase("Limerick", "Limerick City Centre", "Limerick Strand Hotel", true, 2, 1)]
        [TestCase("Limerick", "Limerick City Centre", "George Limerick Hotel", false, 2, 1)]
        [TestCase("Limerick", "Limerick City Centre", "Limerick Strand Hotel", true, 5, 6)]
        public void Validate_SaunaHotelList(string search, string destination, string hotelName, bool exists, int adults, int rooms)
        {
            SearchCriteriaInHome(search, destination, adults, rooms);
            _searchResults.SelectSauna();
            WebDriverUtility.SleepForThreeSeconds();

            var hotel = _searchResults.GetHotelByName(hotelName);
            Assert.AreEqual(exists, hotel.Any());
        }

        private void SearchCriteriaInHome(string search, string destination, int adults, int rooms)
        {
            _home.EnterDestination(search);
            _home.SelectDestination(destination);
            _home.SelectCalendarDates(_fromData, _toDate, 3);
            _home.ClickGuestDetails();
            _home.SelectAdultsCount(adults);
            _home.SelectRoomsCount(rooms);
            _home.ClickSearch();
            _searchResults.CloseMapOverlayIfPopUp();
        }

        [TearDown()]
        public void MyTestCleanup()
        {
            _driver.Quit();
        }
    }
}
