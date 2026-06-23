using OpenQA.Selenium;

namespace SS_003_Babel_Swag_Labs.PageObject.CarritoPage
{
    public class EliminarDelCarritoPage : BasePage
    {

        private By btnCarrito = By.ClassName("shopping_cart_link");
        private By btnEliminar = By.Id("remove-sauce-labs-backpack");

        private By tituloPagina = By.ClassName("title");
        private By productoEnCarrito = By.ClassName("inventory_item_name");


        public EliminarDelCarritoPage(IWebDriver driver) : base(driver) { }


        public void EliminarProducto()
        {
            Click(btnEliminar);
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
