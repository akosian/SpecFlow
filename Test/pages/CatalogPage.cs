using Frame;
using Frame.element;

namespace Test.pages
{
    public class CatalogPage : Form
    {
        public CatalogPage() : base("//div[contains(@class,'catalog-content')]", "Catalog Element Page")
        {
        }

        private Label lblCatalogElementHeader = new Label("//h1[@class='schema-header__title']", "Header");
        
        public string GetCatalogElementHeader()
        {
            return lblCatalogElementHeader.GetText();
        }
    }
}