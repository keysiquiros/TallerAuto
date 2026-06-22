using SS_003_Babel_Swag_Labs.PageObject.CarritoPage;
using SS_003_Babel_Swag_Labs.PageObject.CartPage;
using SS_003_Babel_Swag_Labs.PageObject.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_003_Babel_Swag_Labs.Test.CartTest
{
    public class CompletarCompraTest : BaseTest
    {
        public CompletarCompraTest() : base("CompletarCompra") { }

        [Test]
        public void CompletarCompra()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoTo();
            loginPage.Login("standard_user", "secret_sauce");

            var agregarPage = new AgregarProductoPage(Driver);
            agregarPage.GoTo();
            var compraPage = new CompletarCompraPage(Driver);
            compraPage.GoTo();

            agregarPage.ClickProducto();
            Thread.Sleep(2000);
            agregarPage.AgregarAlCarrito();
            Thread.Sleep(2000);
            agregarPage.IrAlCarrito();
            Thread.Sleep(2000);

            compraPage.ClickCheckout();
            Thread.Sleep(2000);
            compraPage.IngresarDatosCompra("Keysi", "Quiros", "70502");
            Thread.Sleep(2000);
         
            compraPage.FinalizarCompra();
            Thread.Sleep(2000);





            //string expectedUrl = "https://www.saucedemo.com/cart.html";
            //Assert.That(agregarPage.GetCurrentUrl(), Is.EqualTo(expectedUrl));
        }
    }
}
