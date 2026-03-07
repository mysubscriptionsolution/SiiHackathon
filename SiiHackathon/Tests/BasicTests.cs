using Microsoft.Playwright;

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

        [Test]
        public async Task RegisterAccount()
        {
            var email = Helpers.GenerateTestData.GenerateRandomEmail();
            var firstName = Helpers.GenerateTestData.GenerateRandomName();
            var lastName = Helpers.GenerateTestData.GenerateRandomName();
            var registrationPage = new Pages.RegistrationPage(_page);
            await registrationPage.FillInRegisterForm("Test", "Test", ");


             private ILocator FirstNameInput => _page.Locator("#field-firstname");
        private ILocator LastNameInput => _page.Locator("#field-lastname");
        private ILocator EmailInput => _page.Locator("#field-email");
        private ILocator PasswordInput => _page.Locator("#field-password");
    }
}
