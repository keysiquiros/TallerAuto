using OpenQA.Selenium;

namespace SS_003_Babel_Swag_Labs.PageObject.CarritoPage
{
    public class AgregarProductoPage : BasePage
    {
        private readonly string Url = "https://www.saucedemo.com/inventory.html";

        private By btnProducto = By.CssSelector("[data-test='inventory-item-name']");
        private By btnAgregar = By.Id("add-to-cart");
        private By btnCarrito = By.CssSelector("[data-test='shopping-cart-link']");
        private By nombreProducto = By.ClassName("inventory_item_name");
        private By contadorCarrito = By.ClassName("shopping_cart_badge");

        public AgregarProductoPage(IWebDriver driver) : base(driver) { }

        public void GoTo()
        {
            GoToUrl(Url);
        }

        public void ClickProducto()
        {
            Click(btnProducto);
        }

        public void AgregarAlCarrito()
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
    }

}
