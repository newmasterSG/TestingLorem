using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingLorem.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void implicitWait(long timetoWait) => driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timetoWait);

        public void pageload(long timetoWait) => driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timetoWait);
    }
}
