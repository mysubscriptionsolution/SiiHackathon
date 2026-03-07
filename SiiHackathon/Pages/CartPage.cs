using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class CartPage(IPage page) : BasePage(page)
    {
        ILocator cartItem => _page.Locator(".cart-item");

        public async Task RemoveProductFromBasket(string productName)
        {
            var item = cartItem.Filter(new LocatorFilterOptions { HasTextString = productName });
            await item.Locator(".remove-from-cart").ClickAsync();
        }
    }
}
