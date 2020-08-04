using System;
using System.Collections.Generic;
using System.Text;

namespace Frame.element
{
    public class Button : Element
    {

        public Button(string locator, string name)
        {
            this.locator = locator;
            this.name = name;
        }

        public void Click()
        {
            WaitElementBeClickable();
            GetElement().Click();
        }
    }
}
