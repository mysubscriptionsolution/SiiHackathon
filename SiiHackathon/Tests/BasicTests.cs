namespace SiiHackathon.Tests
{
    internal class BasicTests : BaseTest
    {
        [Test]
        public async Task CreateAccount()
        {
            var loginPage = new Pages.LoginPage(_page);
            await loginPage.Login("admin@local.dev", "hackathon-sii-2026");
        }
    }
}
