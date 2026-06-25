using OpenQA.Selenium;

namespace SS_003_Babel_Swag_Labs.PageObject.CheckoutPage
{
    public class CheckoutPage : BasePage
    {
        // Localizadores para ingresar datos
        private By tbxFirstName = By.Id("first-name");
        private By tbxLastName = By.Id("last-name");
        private By tbxZip = By.Id("postal-code");

        // Botones del checkout
        private By btnContinue = By.Id("continue");
        private By btnCancel = By.Id("cancel");
        private By btnFinish = By.Id("finish");

        // Localizadores para validaciones
        private By tituloPagina = By.ClassName("title");
        private By mensajeCompraExitosa = By.ClassName("complete-header");

        public CheckoutPage(IWebDriver driver) : base(driver) { }

        public void IngresarDatosCompra(string firstname, string lastname, string zip)
        {
            InsertarTexto(tbxFirstName, firstname);
            InsertarTexto(tbxLastName, lastname);
            InsertarTexto(tbxZip, zip);
            Click(btnContinue);
        }

        public void CancelarCompra()
        {
            Click(btnCancel);
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