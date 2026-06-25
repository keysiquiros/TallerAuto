using OpenQA.Selenium;


namespace SS_003_Babel_Swag_Labs.PageObject.LoginPage;

public class LoginPage : BasePage
{
    private readonly string loginUrl = "https://www.saucedemo.com/";

    private By tbxUsername = By.Id("user-name");
    private By tbxPassword = By.Id("password");
    private By btnSubmit = By.Id("login-button");
    private By mensajeError = By.CssSelector("[data-test='error']");

    public LoginPage(IWebDriver driver) : base(driver) { }

    public void GoTo()
    {
        GoToUrl(loginUrl);
    }

    public void Login(string username, string password)
    {
        InsertarTexto(tbxUsername, username);
        InsertarTexto(tbxPassword, password);
        Click(btnSubmit);
    }

    public string ObtenerMensajeError()
    {
        return ObtenerTexto(mensajeError);
    }
}
