using Microsoft.Playwright;

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
            var registrationPage = new Pages.RegistrationPage(_page);
            await registrationPage.FillInRegisterForm("Test", "Test", ");


             private ILocator FirstNameInput => _page.Locator("#field-firstname");
        private ILocator LastNameInput => _page.Locator("#field-lastname");
        private ILocator EmailInput => _page.Locator("#field-email");
        private ILocator PasswordInput => _page.Locator("#field-password");
    }
}
