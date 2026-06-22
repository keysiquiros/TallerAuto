using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SS_003_Babel_Swag_Labs.Genericos.DriverConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var spark = new ExtentSparkReporter("Reporte.html");
            extent = new ExtentReports();
            extent.AttachReporter(spark);
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
        }

        [SetUp]

        public void SetUp()
        {
            extentTest = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            options.AddArgument("--incognito"); // modo incógnito, evita perfiles con historial

            // Desactiva gestor de contraseñas
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);

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
