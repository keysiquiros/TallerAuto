using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using SS_003_Babel_Swag_Labs.PageObject.ProductosPage;
using SS_003_Babel_Swag_Labs.PageObject.CarritoPage;

namespace SS_003_Babel_Swag_Labs.Test.CarritoTest
{
    public class EliminarDelCarritoTest : BaseTest
    {
        public EliminarDelCarritoTest() : base("EliminarDelCarrito") { }

        [Test]
        public void EliminarProductoDelCarrito()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var inventarioPage = new InventarioProductosPage(Driver);
            inventarioPage.ClickProducto();
            inventarioPage.AgregarProductoAlCarrito();
            inventarioPage.IrAlCarrito();

            var carritoPage = new CarritoPage(Driver);

            Assert.That(carritoPage.ObtenerTituloPagina(), Is.EqualTo("Your Cart"));
            Assert.That(carritoPage.ProductoVisibleEnCarrito(), Is.True);

            carritoPage.EliminarProducto();

            Assert.That(carritoPage.ProductoVisibleEnCarrito(), Is.False);
        }
    }
}