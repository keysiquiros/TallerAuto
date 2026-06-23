using OpenQA.Selenium;

namespace SS_003_Babel_Swag_Labs.PageObject.CartPage
{
    public class FiltrarProductosPage : BasePage
    {

        private By comboFiltro = By.CssSelector("[data-test='product-sort-container']");

        private By opcionNombreAscendente = By.CssSelector("option[value='az']");
        private By opcionNombreDescendente = By.CssSelector("option[value='za']");
        private By opcionPrecioMenorMayor = By.CssSelector("option[value='lohi']");
        private By opcionPrecioMayorMenor = By.CssSelector("option[value='hilo']");

        private By opcionSeleccionada = By.CssSelector("[data-test='product-sort-container'] option:checked");
        private By primerProducto = By.CssSelector("[data-test='inventory-item-name']");
        private By primerPrecio = By.CssSelector("[data-test='inventory-item-price']");


        public FiltrarProductosPage(IWebDriver driver) : base(driver) { }


        public void AbrirComboFiltro()
        {
            Click(comboFiltro);
        }

        public void SeleccionarNombreAscendente()
        {
            Click(opcionNombreAscendente);
        }

        public void SeleccionarNombreDescendente()
        {
            Click(opcionNombreDescendente);
        }

        public void SeleccionarPrecioMenorAMayor()
        {
            Click(opcionPrecioMenorMayor);
        }

        public void SeleccionarPrecioMayorAMenor()
        {
            Click(opcionPrecioMayorMenor);
        }
        public string ObtenerOpcionSeleccionada()
        {
            return ObtenerTexto(opcionSeleccionada);
        }

        public string ObtenerPrimerProducto()
        {
            return ObtenerTexto(primerProducto);
        }

        public string ObtenerPrimerPrecio()
        {
            return ObtenerTexto(primerPrecio);
        }
    }
}