using System;
using System.Collections.Generic;
using System.Text;

namespace Frame.element
{
   public class Label : BaseElement
    {
        public Label(string locator, string name)
        {
            this.locator = locator;
            this.name = name;
        }

    }
}
