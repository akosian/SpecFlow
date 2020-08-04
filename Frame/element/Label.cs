using System;
using System.Collections.Generic;
using System.Text;

namespace Frame.element
{
   public class Label : Element
    {
        public Label(string locator, string name)
        {
            this.locator = locator;
            this.name = name;
        }

    }
}
