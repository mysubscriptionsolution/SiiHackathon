using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class LoggedInPage(IPage page) : BasePage(page)
    {
        private ILocator LogOutBtn => _page.Locator(".logout");

        public async Task<bool> IsUserLoggedIn()
        {
            return await LogOutBtn.IsVisibleAsync();
        }
    }
}
