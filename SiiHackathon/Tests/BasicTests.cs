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

            var loginPage = await homePage.ClickLoginButton();
            await loginPage.Login("mszymczyk@sii.pl", "6G49v3Vn_zu4R#P");
        }

        [Test]
        public async Task AddProductToCart()
        {
            var homePage = new HomePage(_page);
            await homePage.OpenAsync();
            var productsPage = new ProductsPage(_page);
            await productsPage.ClickProductByName("Hummingbird printed t-shirt");
            var productDetailsPage = new ProductDetailsPage(_page);
            await productDetailsPage.ClickAddToCardButton();
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
