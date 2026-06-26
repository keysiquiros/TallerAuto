using OpenQA.Selenium;

namespace SS_003_Babel_Swag_Labs.PageObject.ProductosPage
{
    public class InventarioProductosPage : BasePage
    {

        // Localizadores para productos
        private By nombreProducto = By.CssSelector("[data-test='inventory-item-name']");
        private By btnAgregar = By.Id("add-to-cart");
        private By btnCarrito = By.CssSelector("[data-test='shopping-cart-link']");
        private By contadorCarrito = By.ClassName("shopping_cart_badge");

        // Localizadores para filtros
        private By comboFiltro = By.CssSelector("[data-test='product-sort-container']");
        private By opcionNombreAscendente = By.CssSelector("option[value='az']");
        private By opcionNombreDescendente = By.CssSelector("option[value='za']");
        private By opcionPrecioMenorMayor = By.CssSelector("option[value='lohi']");
        private By opcionPrecioMayorMenor = By.CssSelector("option[value='hilo']");

        // Localizadores para validaciones
        private By opcionSeleccionada = By.CssSelector("[data-test='product-sort-container'] option:checked");
        private By primerPrecio = By.CssSelector("[data-test='inventory-item-price']");

        public InventarioProductosPage(IWebDriver driver) : base(driver) { }

       
        // Métodos para agregar productos
        public void ClickProducto()
        {
            Click(nombreProducto);
        }

        public void AgregarProductoAlCarrito()
        {
            Click(btnAgregar);
        }

        public void IrAlCarrito()
        {
            Click(btnCarrito);
        }

        public string ObtenerNombreProducto()
        {
            return ObtenerTexto(nombreProducto);
        }

        public string ObtenerContadorCarrito()
        {
            return ObtenerTexto(contadorCarrito);
        }

        // Métodos para filtrar productos
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

        // Métodos para validaciones
        public string ObtenerOpcionSeleccionada()
        {
            return ObtenerTexto(opcionSeleccionada);
        }

        public string ObtenerPrimerProducto()
        {
            return ObtenerTexto(nombreProducto);
        }

        public string ObtenerPrimerPrecio()
        {
            return ObtenerTexto(primerPrecio);
        }
    }
}