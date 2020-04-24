using OpenQA.Selenium;

namespace AutomationChallenge.PageObjects
{
    public class HomePage
    {
        public readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement DestinationTextBox => _driver.FindElement(By.Id("ss"));

        public IWebElement AdultsTextBox => _driver.FindElement(By.Id("group_adults"));

        public IWebElement RoomsTextBox => _driver.FindElement(By.Id("no_rooms"));

        public IWebElement GoRightCalenderButton => _driver.FindElement(By.ClassName("bui-calendar__control--next"));

        public IWebElement SearchButton => _driver.FindElement(By.ClassName("sb-searchbox__button"));

        public IWebElement GuestSpan => _driver.FindElement(By.ClassName("xp__guests__count"));

        public IWebElement AddAdultButton => _driver.FindElement(By.XPath("//button[@aria-label='Increase number of Adults']"));

        public IWebElement ReduceAdultButton => _driver.FindElement(By.XPath("//button[@aria-label='Decrease number of Adults']"));

        public IWebElement AddRoomsButton => _driver.FindElement(By.XPath("//button[@aria-label='Increase number of Rooms']"));

        public IWebElement ReduceRoomsButton => _driver.FindElement(By.XPath("//button[@aria-label='Decrease number of Rooms']"));

        public IWebElement CookiesButton => _driver.FindElement(By.XPath("//button[@data-track-event='m_cookie_warning_closed']"));

        public IWebElement CookieWarningDiv => _driver.FindElement(By.Id("cookie_warning"));

        public IWebElement GetDestinationLink(string destination)
        {
            return _driver.FindElement(By.XPath("//span[text()='" + destination + "']"));
        }

        public IWebElement GetDate(string date)
        {
            return _driver.FindElement(By.XPath("//td[@data-date='" + date + "']"));
        }
    }
}
