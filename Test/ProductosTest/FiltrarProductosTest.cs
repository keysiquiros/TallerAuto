using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using SS_003_Babel_Swag_Labs.PageObject.ProductosPage;

namespace SS_003_Babel_Swag_Labs.Test.ProductosTest
{
    public class FiltrarProductosTest : BaseTest
    {
        public FiltrarProductosTest() : base("FiltrarProductos") { }

        [Test]
        public void FiltrarProductosPorNombreAscendente()
        {
            Login();

            var inventarioPage = new InventarioProductosPage(Driver);

            inventarioPage.AbrirComboFiltro();
            inventarioPage.SeleccionarNombreAscendente();

            Assert.That(inventarioPage.ObtenerOpcionSeleccionada(), Is.EqualTo("Name (A to Z)"));
            Assert.That(inventarioPage.ObtenerPrimerProducto(), Is.EqualTo("Sauce Labs Backpack"));
        }

        [Test]
        public void FiltrarProductosPorNombreDescendente()
        {
            Login();

            var inventarioPage = new InventarioProductosPage(Driver);

            inventarioPage.AbrirComboFiltro();
            inventarioPage.SeleccionarNombreDescendente();

            Assert.That(inventarioPage.ObtenerOpcionSeleccionada(), Is.EqualTo("Name (Z to A)"));
            Assert.That(inventarioPage.ObtenerPrimerProducto(), Is.EqualTo("Test.allTheThings() T-Shirt (Red)"));
        }

        [Test]
        public void FiltrarProductosPorPrecioMenorAMayor()
        {
            Login();

            var inventarioPage = new InventarioProductosPage(Driver);

            inventarioPage.AbrirComboFiltro();
            inventarioPage.SeleccionarPrecioMenorAMayor();

            Assert.That(inventarioPage.ObtenerOpcionSeleccionada(), Is.EqualTo("Price (low to high)"));
            Assert.That(inventarioPage.ObtenerPrimerPrecio(), Is.EqualTo("$7.99"));
        }

        [Test]
        public void FiltrarProductosPorPrecioMayorAMenor()
        {
            Login();

            var inventarioPage = new InventarioProductosPage(Driver);

            inventarioPage.AbrirComboFiltro();
            inventarioPage.SeleccionarPrecioMayorAMenor();

            Assert.That(inventarioPage.ObtenerOpcionSeleccionada(), Is.EqualTo("Price (high to low)"));
            Assert.That(inventarioPage.ObtenerPrimerPrecio(), Is.EqualTo("$49.99"));
        }

        private void Login()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");
        }
    }
}