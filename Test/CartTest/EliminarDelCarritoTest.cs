using SS_003_Babel_Swag_Labs.PageObject.CarritoPage;
using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_003_Babel_Swag_Labs.Test.CarritoTest
{
    public class EliminarDelCarritoTest : BaseTest
    {
        public EliminarDelCarritoTest() : base("EliminarProducto") { }

        [Test]
        public void EliminarProductoDelCarrito()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var agregarPage = new AgregarProductoPage(Driver);
            agregarPage.GoTo();
            var eliminarPage = new EliminarDelCarritoPage(Driver);
            agregarPage.GoTo();

            agregarPage.ClickProducto();
            agregarPage.AgregarAlCarrito();
           
       
            eliminarPage.IrAlCarrito();
            Thread.Sleep(2000); 
            eliminarPage.EliminarProducto();
            Thread.Sleep(2000);

            string expectedUrl = "https://www.saucedemo.com/cart.html";
            Assert.That(agregarPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));
        }
    }
}
