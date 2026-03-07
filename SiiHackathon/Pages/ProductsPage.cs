using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class ProductsPage(IPage page) : BasePage(page)
    {
        ILocator productTile => _page.Locator(".product-miniature");

        public async Task ClickProductByName(string name)
        {
            var product = productTile.Filter(new() { HasTextString = name }).First;
            await product.ClickAsync();
        }
    }
}
