using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using SS_003_Babel_Swag_Labs.PageObject.ProductosPage;
using SS_003_Babel_Swag_Labs.PageObject.CarritoPage;
using SS_003_Babel_Swag_Labs.PageObject.CheckoutPage;

namespace SS_003_Babel_Swag_Labs.Test.CheckoutTest
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

            var inventarioPage = new InventarioProductosPage(Driver);
            inventarioPage.ClickProducto();
            inventarioPage.AgregarProductoAlCarrito();
            inventarioPage.IrAlCarrito();

            var carritoPage = new CarritoPage(Driver);
            carritoPage.ClickCheckout();

            var checkoutPage = new CheckoutPage(Driver);

            Assert.That(checkoutPage.ObtenerTituloPagina(), Is.EqualTo("Checkout: Your Information"));

            checkoutPage.IngresarDatosCompra("Keysi", "Quiros", "70502");

            Assert.That(checkoutPage.ObtenerTituloPagina(), Is.EqualTo("Checkout: Overview"));

            checkoutPage.FinalizarCompra();

            Assert.That(checkoutPage.GetCurrentUrl(), Is.EqualTo("https://www.saucedemo.com/checkout-complete.html"));
            Assert.That(checkoutPage.ObtenerMensajeCompraExitosa(), Is.EqualTo("Thank you for your order!"));
        }
    }
}