using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class ProductDetailsPage(IPage page) : BasePage(page)
    {
        ILocator addToCartButton => _page.Locator(".add-to-cart");

        public async Task<ProductAddedToCartModal> ClickAddToCardButton()
        {
            await addToCartButton.ClickAsync();
            return new ProductAddedToCartModal(_page);
        }
    }
}
