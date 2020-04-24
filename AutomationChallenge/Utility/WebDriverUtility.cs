using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationChallenge
{
    public static class WebDriverUtility
    {
        public static string GetValue(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static void SleepForThreeSeconds()
        {
            Thread.Sleep(3000);
        }
    }
}
