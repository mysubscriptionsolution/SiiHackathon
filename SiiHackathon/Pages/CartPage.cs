using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class CartPage(IPage page) : BasePage(page)
    {
        ILocator cartItem => _page.Locator(".cart-overview").GetByRole(AriaRole.Listitem);
        ILocator removeFromCartButton => _page.Locator(".remove-from-cart");

        ILocator noProductsLabel => _page.Locator(".no-items");

        ILocator proceedToCheckoutButton => _page.Locator(".checkout");

        public async Task RemoveProductFromBasket(string productName)
        {
            var item = cartItem.Filter(new LocatorFilterOptions { HasTextString = productName });
            await item.Locator(removeFromCartButton).ClickAsync();
            await noProductsLabel.WaitForAsync();
        }

        public async Task<OrderSummaryPage> ProceedToCheckout()
        {
            await proceedToCheckoutButton.ClickAsync();
            return new OrderSummaryPage(_page);
        }
    }
}
