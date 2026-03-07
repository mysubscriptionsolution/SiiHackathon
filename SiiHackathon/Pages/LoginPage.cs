using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class LoginPage(IPage page) : BasePage(page)
    {
        public async Task Login(string email, string password)
        {
            await _page.FillAsync("#field-email", email);
            await _page.FillAsync("#field-password", password);
            await _page.ClickAsync("#submit-login");
        }
    }
}
