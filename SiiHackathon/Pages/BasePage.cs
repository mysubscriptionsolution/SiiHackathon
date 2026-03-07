using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class BasePage(IPage page)
    {
        protected readonly IPage _page = page;
    }
}
