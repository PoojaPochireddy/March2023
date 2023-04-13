using OpenQA.Selenium;
using System;


namespace March2023.Pages
{
    public class HomePage
    {
        public void GoToHomePage(IWebDriver driver)
        {
            //navigate to time and material module

            IWebElement Adminstration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            Adminstration.Click();

            IWebElement TMOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TMOption.Click();

        }
    }
}
