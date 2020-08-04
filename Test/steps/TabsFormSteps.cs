﻿using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Test.pages;

namespace Test.steps
{
    [Binding]
    public class TabsFormSteps
    {

        [Given(@"I click (.*) random tab on Tabs form")]
        public void ClickRandomTabAndGetName(string tabStoreName)
        {
            TabsForm form = new TabsForm();
            int tabsNumber = form.GetTabsNumber();
            int locatorNumber = new Random().Next(1, tabsNumber);
            string tabName = form.GetTabName(locatorNumber);
            form.ClickTab(locatorNumber);
            Store.put(tabStoreName, tabName);
        }
    }
}