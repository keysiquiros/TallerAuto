using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_003_Babel_Swag_Labs.PageObject.CarritoPage
{
    public class EliminarDelCarritoPage : BasePage
    {
        private readonly string Url = "https://www.saucedemo.com/inventory.html";

        
        private By btnCarrito = By.ClassName("shopping_cart_link");
        private By btnEliminar = By.Id("remove-sauce-labs-backpack");

        public EliminarDelCarritoPage(IWebDriver driver) : base(driver) { }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        public void EliminarProducto()
        {
            Click(btnEliminar); 
        }

        public void IrAlCarrito()
        {
            Click(btnCarrito); // redirige al carrito
        }
    }
}
