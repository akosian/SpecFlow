﻿using Frame.element;

namespace Test.pages
{
    public class TabsForm : Frame.Form
    {
        public TabsForm() : base("//div[@class='catalog-bar']", "Tabs Form")
        {
        }

        private const string LocTabByLocNumber = "//div[@class='catalog-bar']//li[{0}]";

        private Label lblTab = new Label("//div[@class='catalog-bar']//li", "Tab element");

        public int GetTabsNumber()
        {
           return lblTab.GetCount();
        }

        public string GetTabName(int locatorNumber)
        {
            string locator = string.Format(LocTabByLocNumber, locatorNumber);
            Label lblTab = new Label(locator, "Tab");
            return lblTab.GetText();
        }

        public void ClickTab(int locatorNumber)
        {
            string locator = string.Format(LocTabByLocNumber, locatorNumber) + "//a";
            Button btnTab = new Button(locator, "Tab");
            btnTab.Click();
        }
    }
}