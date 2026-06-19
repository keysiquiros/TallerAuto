using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SS_003_Babel_Swag_Labs.PageObject
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;
        protected WebDriverWait Wait;


        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        protected IWebElement WaitForElement(By locator)
        {
            return Driver.FindElement(locator);

        }
        public string GetCurrentUrl()
        {
            return Driver.Url;
        }
    }
}
