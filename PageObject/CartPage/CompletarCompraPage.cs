using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_003_Babel_Swag_Labs.PageObject.CartPage
{
    public class CompletarCompraPage : BasePage
    {
        private readonly string Url = "https://www.saucedemo.com/inventory.html";

        private By tbxFirstName = By.Id("first-name");
        private By tbxLastName = By.Id("last-name");
        private By tbxZip = By.Id("postal-code");
        private By btnCheckout = By.Id("checkout");
        private By btnContinue = By.Id("continue");
        private By btnFinish = By.Id("finish");

        public CompletarCompraPage(IWebDriver driver) : base(driver) { }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl(Url);
        }

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
    }
}
