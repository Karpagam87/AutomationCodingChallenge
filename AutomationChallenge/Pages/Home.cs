using OpenQA.Selenium;

using AutomationChallenge.PageObjects;

namespace AutomationChallenge.Pages
{
    /// <summary>
    /// Class for home page actions
    /// </summary>
    public class Home: HomePage
    {
        /// <summary>
        /// Constructor for <see cref="HomePage"/>
        /// </summary>
        /// <param name="driver">webdriver</param>
        public Home(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Selects the calender dates for reservation
        /// </summary>
        /// <param name="fromDate">check-in date</param>
        /// <param name="toDate">check-out date</param>
        /// <param name="forwardClicks">Skip months for future selection</param>
        public void SelectCalendarDates(string fromDate, string toDate, int forwardClicks)
        {
            var iteration = 1;
            while (iteration < forwardClicks)
            {
                GoRightCalenderButton.Click();
                iteration++;
            }
            GetDate(fromDate).Click();
            GetDate(toDate).Click();
        }
        /// <summary>
        /// Enters the preferred destination in the text box
        /// </summary>
        /// <param name="destination">Preferred city of stay</param>
        public void EnterDestination(string destination)
        {
            DestinationTextBox.SendKeys(destination);
        }

        /// <summary>
        /// Selects the preferred destination from dropdown
        /// </summary>
        /// <param name="destination">Preferred city of stay</param>
        public void SelectDestination(string destination)
        {
            GetDestinationLink(destination).Click();
        }

        /// <summary>
        /// Clicks on the search button
        /// </summary>
        public void ClickSearch()
        {
            SearchButton.Click();
        }

        /// <summary>
        /// Selects the number of guests to be included
        /// </summary>
        /// <param name="adults">No of adults</param>
        public void SelectAdultsCount(int adults)
        {
            var defaultAdultsValue = AdultsTextBox.GetValue();

            if (int.TryParse(defaultAdultsValue, out int defaultAdultsCount))
            {
                if (defaultAdultsCount > adults)
                {
                    while (defaultAdultsCount < adults)
                    {
                        ReduceAdultButton.Click();
                        defaultAdultsCount--;
                    }
                }
                else if (defaultAdultsCount < adults)
                {
                    while (defaultAdultsCount < adults)
                    {
                        AddAdultButton.Click();
                        defaultAdultsCount++;
                    }
                }
            }
        }

        /// <summary>
        /// Selects the number of rooms required
        /// </summary>
        /// <param name="rooms">No of rooms</param>
        public void SelectRoomsCount(int rooms)
        {
            var defaultRoomsValue = RoomsTextBox.GetValue();
            if (int.TryParse(defaultRoomsValue, out int defaultRoomsCount))
            {
                if (defaultRoomsCount > rooms)
                {
                    while (defaultRoomsCount < rooms)
                    {
                        ReduceRoomsButton.Click();
                        defaultRoomsCount--;
                    }
                }
                else if (defaultRoomsCount < rooms)
                {
                    while (defaultRoomsCount < rooms)
                    {
                        AddRoomsButton.Click();
                        defaultRoomsCount++;
                    }
                }
            }
        }

        /// <summary>
        /// Clicks to open guest and room addon box
        /// </summary>
        public void ClickGuestDetails()
        {
            GuestSpan.Click();
        }
    }

}
