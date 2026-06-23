using SS_003_Babel_Swag_Labs.PageObject.CarritoPage;
using SS_003_Babel_Swag_Labs.PageObject.CartPage;
using SS_003_Babel_Swag_Labs.PageObject.LoginPage;

namespace SS_003_Babel_Swag_Labs.Test.CartTest
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

            var agregarPage = new AgregarProductoPage(Driver);
            agregarPage.ClickProducto();
            agregarPage.AgregarAlCarrito();
            agregarPage.IrAlCarrito();

            var compraPage = new CompletarCompraPage(Driver);
            compraPage.ClickCheckout();
            compraPage.IngresarDatosCompra("Keysi", "Quiros", "70502");

            var cancelarPage = new CancelarCompraPage(Driver);
            cancelarPage.ClickCancel();

            string expectedUrl = "https://www.saucedemo.com/inventory.html";

            Assert.That(cancelarPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));
            Assert.That(cancelarPage.ObtenerTituloPagina(), Is.EqualTo("Products"));
        }
    }
}
