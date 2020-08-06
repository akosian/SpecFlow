using Frame;
using Frame.element;

namespace Test.pages
{
    public class LoginForm : Form
    {
        public LoginForm() : base("//div[@class='auth-form__body']", "Login Form")
        {
        }

        private TextBox txbEmail = new TextBox("//div[@class='auth-form__body']//input[@type='text']", "Email field");
        private TextBox txbPassword = new TextBox("//div[@class='auth-form__body']//input[@type='password']", "Password field");
        private Button btnLogin = new Button("//div[@class='auth-form__body']//button[@type='submit']", "Login button");

        private Label lblForm = new Label("//div[@class='auth-form__body']", "Form");

        public void WaitFormLoad()
        {
            lblForm.WaitElement();
        }

        public void FillEmail(string email)
        {
            txbEmail.SetText(email);
        }

        public void FillPassword(string password)
        {
            txbPassword.SetText(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}