using Frame;
using Frame.element;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.pages
{
    public class CatalogElementPage : Form
    {
        public CatalogElementPage() : base("//div[contains(@class,'catalog-content')]", "Catalog Element Page")
        {
        }

        private Label lblCatalogElementHeader = new Label("//h1[@class='schema-header__title']", "Header");
        
        public string GetCatalogElementHeader()
        {
            return lblCatalogElementHeader.GetText();
        }
    }
}
