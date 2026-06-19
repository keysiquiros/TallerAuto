using OpenQA.Selenium;


namespace SS_003_Babel_Swag_Labs.PageObject.LoginPage;

public class LoginPage : BasePage
{
    private readonly string loginUrl = "https://www.saucedemo.com/";

    private By tbxUsername = By.Id("user-name");
    private By tbxPassword = By.Id("password");
    private By btnSubmit = By.Id("login-button");

    public LoginPage(IWebDriver driver) : base(driver) { }

    public void GoTo()
    {
        Driver.Navigate().GoToUrl(loginUrl);
    }

    public void EnterUsername(string username)
    {
        WaitForElement(tbxUsername).Clear();
        Driver.FindElement(tbxUsername).SendKeys(username);
    }
    public void EnterPassword(string password)
    {
        WaitForElement(tbxPassword).Clear();
        Driver.FindElement(tbxPassword).SendKeys(password);
    }

    public void ClickLogin()
    {
        Driver.FindElement(btnSubmit).Click();
    }
      
    public void Login(string username, string password)
    {
        EnterUsername(username);
        EnterPassword(password);
        ClickLogin();
    }
}
