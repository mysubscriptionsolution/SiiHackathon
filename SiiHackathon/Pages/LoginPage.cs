using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class LoginPage(IPage page) : BasePage(page)
    {
        private ILocator EmailInput => _page.Locator("#field-email");
        private ILocator PasswordInput => _page.Locator("#field-password");
        private ILocator SignInButton => _page.Locator("#submit-login");

        public async Task Login(string email, string password)
        {
            await EmailInput.FillAsync(email);
            await PasswordInput.FillAsync(password);
            await SignInButton.ClickAsync();
        }
    }
}
