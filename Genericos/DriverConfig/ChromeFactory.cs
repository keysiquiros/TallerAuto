using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SS_003_Babel_Swag_Labs.Genericos.DriverConfig
{
    public class ChromeFactory
    {
        public static IWebDriver CrearDriver(ChromeOptions options)
        {
            return new ChromeDriver(options);

        }
    }
}
