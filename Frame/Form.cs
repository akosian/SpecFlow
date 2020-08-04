using Frame.element;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frame
{
    public class Form
    {
        protected string locator;
        protected string name;

        public Form(string locator, string name)
        {
            this.locator = locator;
            this.name = name;
            WaitPageLoad();
        }

        protected void WaitPageLoad()
        {
            new Label(locator, name).WaitElement();
        }
    }
}
