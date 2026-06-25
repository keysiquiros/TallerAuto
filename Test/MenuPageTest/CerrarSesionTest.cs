using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using SS_003_Babel_Swag_Labs.PageObject.MenuPage;

namespace SS_003_Babel_Swag_Labs.Test.LoginTest
{
    public class CerrarTest : BaseTest
    {
        public CerrarTest() : base("CerrarSesion") { }

        [Test]
        public void CerrarSesion()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var menuPage = new MenuPage(Driver);
            menuPage.AbrirMenu();
            menuPage.CerrarSesion();

            Assert.That(menuPage.GetCurrentUrl(), Is.EqualTo("https://www.saucedemo.com/"));
        }
    }
}