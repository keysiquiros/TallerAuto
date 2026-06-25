using OpenQA.Selenium;

namespace SS_003_Babel_Swag_Labs.PageObject.CarritoPage
{
    public class CarritoPage : BasePage
    {
        // Localizadores del carrito
        private By btnEliminar = By.Id("remove-sauce-labs-backpack");
        private By btnCheckout = By.Id("checkout");
        private By tituloPagina = By.ClassName("title");
        private By productoEnCarrito = By.ClassName("inventory_item_name");

        public CarritoPage(IWebDriver driver) : base(driver) { }

        public void EliminarProducto()
        {
            Click(btnEliminar);
        }

        public void ClickCheckout()
        {
            Click(btnCheckout);
        }

        public string ObtenerTituloPagina()
        {
            return ObtenerTexto(tituloPagina);
        }

        public string ObtenerNombreProducto()
        {
            return ObtenerTexto(productoEnCarrito);
        }

        public bool ProductoVisibleEnCarrito()
        {
            return ExisteElemento(productoEnCarrito);
        }
    }
}