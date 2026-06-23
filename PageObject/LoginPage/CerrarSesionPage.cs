using OpenQA.Selenium;

namespace SS_003_Babel_Swag_Labs.PageObject.LoginPage
{
    public class CerrarSesionPage : BasePage
    {

        private By btnMenu = By.Id("react-burger-menu-btn");
        private By btnLogout = By.Id("logout_sidebar_link");
        private By tbxUsername = By.Id("user-name");

        public CerrarSesionPage(IWebDriver driver) : base(driver) { }


        public void AbrirMenu()
        {
            Click(btnMenu);
        }
        public void CerrarSesion()
        {
            Click(btnLogout);
        }
        public bool LoginVisible()
        {
            return Driver.FindElements(tbxUsername).Count > 0;
        }
    }
}