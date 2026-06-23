using SS_003_Babel_Swag_Labs.PageObject.CarritoPage;
using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_003_Babel_Swag_Labs.Test.CartTest
{
    public class AgregarProductoTest : BaseTest
    {
        public AgregarProductoTest() : base("AgregarProducto") { }

        [Test]
        public void AgregarProductoAlCarrito()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var agregarPage = new AgregarProductoPage(Driver);

            string productoEsperado = agregarPage.ObtenerNombreProducto();

            agregarPage.ClickProducto();
            agregarPage.AgregarAlCarrito();

            Assert.That(agregarPage.ObtenerContadorCarrito(), Is.EqualTo("1"));

            agregarPage.IrAlCarrito();

            string expectedUrl = "https://www.saucedemo.com/cart.html";
            Assert.That(agregarPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));

            string productoActual = agregarPage.ObtenerNombreProducto();
            Assert.That(productoActual, Is.EqualTo(productoEsperado));
        }
    }
}
