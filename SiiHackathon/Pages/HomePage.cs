using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class HomePage(IPage page) : BasePage(page)
    {
        private ILocator LoginButton => _page.GetByRole(AriaRole.Link, new() { Name = " Sign in" });
        ILocator CartButton => _page.Locator(".cart-preview");
        ILocator CartProductsCountLabel => _page.Locator(".cart-products-count");

        public async Task OpenAsync()
        {
            await _page.GotoAsync("/");
        }

        public async Task<LoginPage> ClickLoginButton()
        {
            await LoginButton.ClickAsync();
            return new LoginPage(_page);
        }

        public async Task<RegistrationPage> GoToRegistrationPage()
        {
            await _page.GotoAsync(Const.Urls.Registration);
            return new RegistrationPage(_page);
        }

        public async Task<int> GetProductsCountInCart()
        {
            var countText = await CartProductsCountLabel.InnerTextAsync();
            countText = countText.Trim('(', ')');
            return int.Parse(countText);
        }
    }
}
