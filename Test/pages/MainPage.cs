using Frame.element;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.pages
{
    public class MainPage
    {
        private Button btnLoginIcon = new Button("//div[contains(@class,'auth-bar__item')]", "Login button");
        private Button btnUserIcon = new Button("//div[@id='userbar']//a", "User icon");
        private Button btnLogout = new Button("//div[@id='userbar']//a[contains(text(),'Выйти')]", "Exist button");
        private Button btnCatalog = new Button("//ul[@class='b-main-navigation']//a[.//span[normalize-space(text())='Каталог']]", "Catalog");

        public void ClickUserIcon()
        {
            btnUserIcon.Click();
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
