using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SiiHackathon.Pages
{
    internal class LoggedInPage : BasePage
    {
        public LoggedInPage(IPage page) : base(page)
        {

        }
        private ILocator LogOutBtn => _page.Locator(".logout");

        public async Task<bool> IsUserLoggedIn()
        {
            return await LogOutBtn.IsVisibleAsync();
        }
    }
}
