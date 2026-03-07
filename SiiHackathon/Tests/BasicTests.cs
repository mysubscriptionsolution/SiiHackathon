using SiiHackathon.Pages;

namespace SiiHackathon.Tests
{
    internal class BasicTests : BaseTest
    {
        [Test]
        public async Task LoginAsAdministrator()
        {
            var homePage = new HomePage(_page);
            await homePage.OpenAsync();
            await homePage.ClickLoginButton();

            var loginPage = new LoginPage(_page);
            await loginPage.Login("admin@local.dev", "hackathon-sii-2026");
        }
    }
}
