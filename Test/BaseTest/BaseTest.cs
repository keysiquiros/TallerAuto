using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SS_003_Babel_Swag_Labs.Genericos.DriverConfig;

namespace SS_003_Babel_Swag_Labs.Test
{
    public abstract class BaseTest
    {

        protected IWebDriver Driver;

        protected string reportTestPage = "";
        public static ExtentTest extentTest;
        public static ExtentReports extent;

        public BaseTest(string pageContext)
        {

            reportTestPage = pageContext;
        }

        [OneTimeSetUp]
        public void StarReport()
        {
            string fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            string rutaReporte = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Reports",
                $"Reporte_{fecha}.html"
            );
            Directory.CreateDirectory(Path.GetDirectoryName(rutaReporte)!);
            var spark = new ExtentSparkReporter(rutaReporte);

            extent = new ExtentReports();
            extent.AttachReporter(spark);

        }
       

        [SetUp]

        public void SetUp()
        {
            extentTest = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            // Desactiva gestor de contraseñas
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);

            Driver = ChromeFactory.CrearDriver(options);
        }

        [TearDown]

        public void TearDown()
        {

            var status = TestContext.CurrentContext.Result.Outcome.Status;

            if (status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                extentTest.Pass("Test exitoso");
            }
            else
            {
                extentTest.Fail(
                TestContext.CurrentContext.Result.Message);
            }
            Driver?.Dispose();
        }

        [OneTimeTearDown]

        public void EndReport()
        {

            extent.Flush();
        }
    }
}
