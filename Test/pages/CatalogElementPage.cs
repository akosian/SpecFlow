using Frame.element;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.pages
{
    public class CatalogElementPage
    {
        private Label lblCatalogElementHeader = new Label("//h1[@class='schema-header__title']", "Header");
        
        public string GetCatalogElementHeader()
        {
            return lblCatalogElementHeader.GetText();
        }
    }
}
