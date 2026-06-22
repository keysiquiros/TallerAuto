using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_003_Babel_Swag_Labs.PageObject.CarritoPage
{
    public class AgregarProductoPage : BasePage
    {
        private readonly string Url = "https://www.saucedemo.com/inventory.html";

        private By btnProducto = By.ClassName("inventory_item_name");
        private By btnAgregar = By.Id("add-to-cart");
        private By btnCarrito = By.ClassName("shopping_cart_link");

        public AgregarProductoPage(IWebDriver driver) : base(driver) { }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        public void ClickProducto()
        {
            Click(btnProducto); // redirige a detalle
        }

        public void AgregarAlCarrito()
        {
            Click(btnAgregar); 
        }

        public void IrAlCarrito()
        {
            Click(btnCarrito); // redirige al carrito
        }
    }

}
