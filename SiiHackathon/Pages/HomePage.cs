using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class HomePage(IPage page) : BasePage(page)
    {
        private ILocator LoginButton => _page.GetByRole(AriaRole.Link, new() { Name = " Sign in" });

        public async Task OpenAsync()
        {
            await _page.GotoAsync("/");
        }

        public async Task<LoginPage> ClickLoginButton()
        {
            await LoginButton.ClickAsync();
            return new LoginPage(_page);
        }
    }
}
