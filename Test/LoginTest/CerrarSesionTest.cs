using SS_003_Babel_Swag_Labs.PageObject.CartPage;
using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_003_Babel_Swag_Labs.Test.LoginTest
{
    [TestFixture]

    public class CerrarSesionTest : BaseTest
    {
        public CerrarSesionTest() : base("CerrarSesion") { }

        [Test]
        public void CerrarSesion()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var cerrarSesionPage = new CerrarSesionPage(Driver);
            cerrarSesionPage.AbrirMenu();
            cerrarSesionPage.CerrarSesion();

            string expectedUrl = "https://www.saucedemo.com/";

            Assert.That(cerrarSesionPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));
            Assert.That(cerrarSesionPage.LoginVisible(), Is.True);
        }

    }
}