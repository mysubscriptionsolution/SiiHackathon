using Microsoft.Playwright;
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

        [Test]
        public async Task RegisterAccount()
        {
            var email = Helpers.GenerateTestData.GenerateRandomEmail();
            var firstName = Helpers.GenerateTestData.GenerateRandomName();
            var lastName = Helpers.GenerateTestData.GenerateRandomName();
            var password = Helpers.GenerateTestData.GenerateRandomPassword();
            var homePage = new HomePage(_page);
            var registrationPage = await homePage.GoToRegistrationPage();
            await registrationPage.FillInRegisterForm(firstName, lastName, email, password);
            var loggedInPage = await registrationPage.ClickSave();
            Assert.That(await loggedInPage.IsUserLoggedIn(), Is.True, "User should be logged in after registration");
        }
    }
}
