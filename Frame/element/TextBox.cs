using System;
using System.Collections.Generic;
using System.Text;

namespace Frame.element
{
    public class TextBox : BaseElement
    {

        public TextBox(string locator, string name)
        {
            this.locator = locator;
            this.name = name;
        }

        public void SetText(string text)
        {
            GetElement().SendKeys(text);
        }
    }
}
