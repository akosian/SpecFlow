using Frame;
using Frame.element;

namespace Test.pages
{
    public class MainPage : Form
    {
        public MainPage() : base("//div//img[@class='onliner_logo']", "Main Page")
        {
        }

        private Button btnLoginIcon = new Button("//div[contains(@class,'auth-bar__item')]", "Login button");
        private Button btnUserIcon = new Button("//div[@id='userbar']//a", "User icon");
        private Button btnLogout = new Button("//div[@id='userbar']//a[contains(text(),'Выйти')]", "Exist button");
        private Button btnCatalog = new Button("//ul[@class='b-main-navigation']//a[.//span[normalize-space(text())='Каталог']]", "Catalog");

        private Label lblAutorizedUserIcon = new Label("//div[@id='userbar']//div[contains(@class,'profile__item')]//a", "Authorized User Icon");

        public void ClickUserIcon()
        {
            btnUserIcon.Click();
        }

        public bool IsAuthorizedUserIconPresent()
        {
            return lblAutorizedUserIcon.isElementPresent();
        }

        public void ClickCatalog()
        {
            btnCatalog.Click();
        }

        public void ClickLogout()
        {
            btnLogout.Click();
        }

        public void ClickLoginIcon()
        {
            btnLoginIcon.Click();
        }
    }
}