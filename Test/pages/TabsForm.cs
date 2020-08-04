using Frame.element;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.pages
{
    public class TabsForm
    {
        private const string LocTabByLocNumber = "//div[@class='catalog-bar']//li[{0}]";

        private Label lblTab = new Label("//div[@class='catalog-bar']//li", "Tab element");

        public int GetTabsNumber()
        {
           return lblTab.GetCount();
        }

        public string GetTabName(int locatorNumber)
        {
            string locator = string.Format("//div[@class='catalog-bar']//li[{0}]", locatorNumber);
            Label lblTab = new Label(locator, "Tab");
            return lblTab.GetText();
        }

        public void ClickTab(int locatorNumber)
        {
            string locator = string.Format("//div[@class='catalog-bar']//li[{0}]" + "//a", locatorNumber);
            Button btnTab = new Button(locator, "Tab");
            btnTab.Click();
        }
    }
}
