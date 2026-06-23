using OpenQA.Selenium;

namespace SS_003_Babel_Swag_Labs.PageObject.CartPage
{
    public class CompletarCompraPage : BasePage
    {


        private By tbxFirstName = By.Id("first-name");
        private By tbxLastName = By.Id("last-name");
        private By tbxZip = By.Id("postal-code");

        private By btnCheckout = By.Id("checkout");
        private By btnContinue = By.Id("continue");
        private By btnFinish = By.Id("finish");

        private By tituloPagina = By.ClassName("title");
        private By mensajeCompraExitosa = By.ClassName("complete-header");

        public CompletarCompraPage(IWebDriver driver) : base(driver) { }


        public void ClickCheckout()
        {
            Click(btnCheckout);
        }

        public void IngresarDatosCompra(string firstname, string lastname, string zip)
        {
            InsertarTexto(tbxFirstName, firstname);
            InsertarTexto(tbxLastName, lastname);
            InsertarTexto(tbxZip, zip);
            Click(btnContinue);
        }

        public void FinalizarCompra()
        {
            Click(btnFinish);
        }
        public string ObtenerTituloPagina()
        {
            return ObtenerTexto(tituloPagina);
        }

        public string ObtenerMensajeCompraExitosa()
        {
            return ObtenerTexto(mensajeCompraExitosa);
        }
    }
}
