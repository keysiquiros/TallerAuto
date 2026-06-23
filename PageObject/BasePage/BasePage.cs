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

        protected void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
        protected IWebElement WaitForElement(By locator)
        {
            return Wait.Until(driver =>
            {
                var element = driver.FindElement(locator);

                if (element.Displayed && element.Enabled)
                {
                    return element;
                }

                return null;
            });
        }
        public string GetCurrentUrl()
        {
            return Driver.Url;
        }
        protected void InsertarTexto(By localizador, string texto)
        {
            IWebElement element = WaitForElement(localizador);
            element.Clear();
            element.SendKeys(texto);
        }
        protected void Click(By locator)
        {
            IWebElement element = WaitForElement(locator);
            element.Click();
        }
        protected string ObtenerTexto(By locator)
        {
            return WaitForElement(locator).Text;
        }
        protected bool ExisteElemento(By locator)
        {
            return Driver.FindElements(locator).Count > 0;
        }

    }
}
