using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using System.Threading;

namespace SS_003_Babel_Swag_Labs.Test.LoginTest
{
    [TestFixture]

    public class LoginTest : BaseTest
    {
        public LoginTest() : base("Login") { }

        [Test]

        public void LoginCorrecto()
        {

            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");
            //Thread.Sleep(2000);
            string expectedUrl = "https://www.saucedemo.com/inventory.html";
            Assert.That(loginPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));
       
        }

        [Test]
        public void LoginIncorrecto()
        {
            var loginPage = new LoginPage(Driver);

            loginPage.GoTo();
            loginPage.Login("usuario_incorrecto", "password_incorrecto");

            string mensajeEsperado = "Epic sadface: Username and password do not match any user in this service";

            Assert.That(loginPage.ObtenerMensajeError(), Is.EqualTo(mensajeEsperado));
        }
    }
}
