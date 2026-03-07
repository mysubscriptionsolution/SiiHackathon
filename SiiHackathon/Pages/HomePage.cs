using Microsoft.Playwright;

namespace SiiHackathon.Pages
{
    internal class HomePage
    {
        private readonly IPage page;

        ILocator LoginButton => page.GetByRole(AriaRole.Link, new() { Name = " Sign in" });

        public HomePage(IPage page)
        {
            this.page = page;
        }

        public void ClickLoginButton()
        {
            LoginButton.ClickAsync();
        }
    }
}
