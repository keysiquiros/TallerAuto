using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using SS_003_Babel_Swag_Labs.PageObject.ProductosPage;

namespace SS_003_Babel_Swag_Labs.Test.ProductosTest
{
    public class AgregarAlCarritoTest : BaseTest
    {
        public AgregarAlCarritoTest() : base("AgregarProducto") { }

        [Test]
        public void AgregarProductoAlCarrito()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var inventarioPage = new InventarioProductosPage(Driver);

            string productoEsperado = inventarioPage.ObtenerNombreProducto();

            inventarioPage.ClickProducto();
            inventarioPage.AgregarProductoAlCarrito();

            Assert.That(inventarioPage.ObtenerContadorCarrito(), Is.EqualTo("1"));

            inventarioPage.IrAlCarrito();


            string expectedUrl = "https://www.saucedemo.com/cart.html";
            Assert.That(inventarioPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));

            string productoActual = inventarioPage.ObtenerNombreProducto();
            Assert.That(productoActual, Is.EqualTo(productoEsperado));
        }
    }
}