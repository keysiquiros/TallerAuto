using OpenQA.Selenium;

namespace SS_003_Babel_Swag_Labs.PageObject.CartPage
{
    public class CancelarCompraPage : BasePage
    {

        private By btnCancel = By.Id("cancel");
        private By tituloPagina = By.ClassName("title");

        public CancelarCompraPage(IWebDriver driver) : base(driver) { }


        public void ClickCancel()
        {
            Click(btnCancel);
        }
        public string ObtenerTituloPagina()
        {
            return ObtenerTexto(tituloPagina);
        }

    }
}
