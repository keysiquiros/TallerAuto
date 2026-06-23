using SS_003_Babel_Swag_Labs.PageObject.CartPage;
using SS_003_Babel_Swag_Labs.PageObject.LoginPage;

namespace SS_003_Babel_Swag_Labs.Test.CartTest
{
    public class FiltrarProductosTest : BaseTest
    {
        public FiltrarProductosTest() : base("FiltrarProductos") { }


        [Test]
        public void FiltrarProductosPorNombreAscendente()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var filtrarPage = new FiltrarProductosPage(Driver);

            filtrarPage.AbrirComboFiltro();
            filtrarPage.SeleccionarNombreAscendente();

            Assert.That(filtrarPage.ObtenerOpcionSeleccionada(), Is.EqualTo("Name (A to Z)"));
            Assert.That(filtrarPage.ObtenerPrimerProducto(), Is.EqualTo("Sauce Labs Backpack"));
        }

        [Test]
        public void FiltrarProductosPorNombreDescendente()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var filtrarPage = new FiltrarProductosPage(Driver);

            filtrarPage.AbrirComboFiltro();
            filtrarPage.SeleccionarNombreDescendente();

            Assert.That(filtrarPage.ObtenerOpcionSeleccionada(), Is.EqualTo("Name (Z to A)"));
            Assert.That(filtrarPage.ObtenerPrimerProducto(), Is.EqualTo("Test.allTheThings() T-Shirt (Red)"));
        }

        [Test]
        public void FiltrarProductosPorPrecioMenorAMayor()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var filtrarPage = new FiltrarProductosPage(Driver);

            filtrarPage.AbrirComboFiltro();
            filtrarPage.SeleccionarPrecioMenorAMayor();

            Assert.That(filtrarPage.ObtenerOpcionSeleccionada(), Is.EqualTo("Price (low to high)"));
            Assert.That(filtrarPage.ObtenerPrimerPrecio(), Is.EqualTo("$7.99"));
        }

        [Test]
        public void FiltrarProductosPorPrecioMayorAMenor()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var filtrarPage = new FiltrarProductosPage(Driver);

            filtrarPage.AbrirComboFiltro();
            filtrarPage.SeleccionarPrecioMayorAMenor();

            Assert.That(filtrarPage.ObtenerOpcionSeleccionada(), Is.EqualTo("Price (high to low)"));
            Assert.That(filtrarPage.ObtenerPrimerPrecio(), Is.EqualTo("$49.99"));
        }
    }
}