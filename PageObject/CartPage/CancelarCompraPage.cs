using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_003_Babel_Swag_Labs.PageObject.CartPage
{
    public class CancelarCompraPage : BasePage
    {
        private readonly string Url = "https://www.saucedemo.com/inventory.html";


        private By btnCancel = By.Id("cancel");

        public CancelarCompraPage(IWebDriver driver) : base(driver) { }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        public void ClickCancel()
        {
            Click(btnCancel);
        }


    }
}
