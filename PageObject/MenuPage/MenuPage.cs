using OpenQA.Selenium;

namespace SS_003_Babel_Swag_Labs.PageObject.MenuPage
{
    public class MenuPage : BasePage
    {
        private By btnMenu = By.Id("react-burger-menu-btn");
        private By btnLogout = By.Id("logout_sidebar_link");

        public MenuPage(IWebDriver driver) : base(driver) { }

        public void AbrirMenu()
        {
            Click(btnMenu);
        }

        public void CerrarSesion()
        {
            Click(btnLogout);
        }
    }
}