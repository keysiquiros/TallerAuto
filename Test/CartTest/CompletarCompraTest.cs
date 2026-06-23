using SS_003_Babel_Swag_Labs.PageObject.CarritoPage;
using SS_003_Babel_Swag_Labs.PageObject.CartPage;
using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_003_Babel_Swag_Labs.Test.CartTest
{
    public class CompletarCompraTest : BaseTest
    {
        public CompletarCompraTest() : base("CompletarCompra") { }

        [Test]
        public void CompletarCompra()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var agregarPage = new AgregarProductoPage(Driver);
            agregarPage.ClickProducto();
            agregarPage.AgregarAlCarrito();
            agregarPage.IrAlCarrito();

            var compraPage = new CompletarCompraPage(Driver);
            compraPage.ClickCheckout();

            Assert.That(compraPage.ObtenerTituloPagina(), Is.EqualTo("Checkout: Your Information"));

            compraPage.IngresarDatosCompra("Keysi", "Quiros", "70502");

            Assert.That(compraPage.ObtenerTituloPagina(), Is.EqualTo("Checkout: Overview"));

            compraPage.FinalizarCompra();

            Assert.That(compraPage.GetCurrentUrl(), Is.EqualTo("https://www.saucedemo.com/checkout-complete.html"));
            Assert.That(compraPage.ObtenerMensajeCompraExitosa(), Is.EqualTo("Thank you for your order!"));
        }
    }
}
