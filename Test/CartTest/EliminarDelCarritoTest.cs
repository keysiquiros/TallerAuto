using SS_003_Babel_Swag_Labs.PageObject.CarritoPage;
using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_003_Babel_Swag_Labs.Test.CartTest
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
            agregarPage.ClickProducto();
            agregarPage.AgregarAlCarrito();
            agregarPage.IrAlCarrito();

            var eliminarPage = new EliminarDelCarritoPage(Driver);

            Assert.That(eliminarPage.ObtenerTituloPagina(), Is.EqualTo("Your Cart"));
            Assert.That(eliminarPage.ProductoVisibleEnCarrito(), Is.True);
           
            eliminarPage.EliminarProducto();
            
            Assert.That(eliminarPage.ProductoVisibleEnCarrito(), Is.False);
        }
    }
}
