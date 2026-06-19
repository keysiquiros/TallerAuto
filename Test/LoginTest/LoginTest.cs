using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using System.Threading;

namespace SS_003_Babel_Swag_Labs.Test.LoginTest
{
    [TestFixture]

    public class LoginTest : BaseTest
    {
        public LoginTest() : base("Login") { }

        [Test]

        public void LoginCorrecto_RedireccionExitosa()
        {

            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            string expectedUrl = "https://www.saucedemo.com/inventory.html";
            Assert.That(loginPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));
            Thread.Sleep(2000);
        }

        [Test]

        public void LoginIncorrecto()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            
            loginPage.Login("standarduser", "secret_sauce");
            


            string expectedUrl = "https://www.saucedemo.com/";
            Assert.That(loginPage.GetCurrentUrl(), Is.EqualTo(expectedUrl), "La URL no coincide con la espera.");
            Thread.Sleep(2000);
          
        }
    }
}
