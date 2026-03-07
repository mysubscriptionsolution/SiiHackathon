using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class ProductAddedToCartModal(IPage page) : BasePage(page)
    {
        ILocator modalParentLocator => _page.Locator(".modal-content").Filter(new() { Visible = true});
        ILocator productAddedConfirmationText => modalParentLocator.Locator(".modal-title");
        ILocator proceedToCheckoutButton => modalParentLocator.Locator(".btn-primary");
        public async Task<string> GetConfirmationText()
        {
            return await productAddedConfirmationText.InnerTextAsync();
        }

        public async Task<CartPage> ProceedToCheckout()
        {
            await proceedToCheckoutButton.ClickAsync();
            return new CartPage(_page);
        }
    }
}
