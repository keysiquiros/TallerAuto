using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using SS_003_Babel_Swag_Labs.PageObject.ProductosPage;
using SS_003_Babel_Swag_Labs.PageObject.CarritoPage;
using SS_003_Babel_Swag_Labs.PageObject.CheckoutPage;

namespace SS_003_Babel_Swag_Labs.Test.CheckoutTest
{
    public class CancelarCompraTest : BaseTest
    {
        public CancelarCompraTest() : base("CancelarCompra") { }

        [Test]
        public void CancelarCompra()
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

            checkoutPage.CancelarCompra();

            Assert.That(checkoutPage.GetCurrentUrl(), Is.EqualTo("https://www.saucedemo.com/inventory.html"));
            Assert.That(checkoutPage.ObtenerTituloPagina(), Is.EqualTo("Products"));
        }
    }
}