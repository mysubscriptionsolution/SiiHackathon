using SiiHackathon.Models.DataModels;
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
            var credentials = Credentials.LoadCredentialsDataFromFile();

            await loginPage.Login(credentials.Login!, credentials.Password!);
        }

        [Test]
        public async Task AddProductToCart()
        {
            var homePage = new HomePage(_page);
            await homePage.OpenAsync();
            var productsPage = new ProductsPage(_page);
            await productsPage.ClickProductByName("Hummingbird printed t-shirt");
            var productDetailsPage = new ProductDetailsPage(_page);
            var productAddedToCartModal = await productDetailsPage.ClickAddToCardButton();
            Assert.That(await productAddedToCartModal.GetConfirmationText(), Does.Contain("Product successfully added to your shopping cart"));
            Assert.That(await homePage.GetProductsCountInCart(), Is.EqualTo(1));
        }

        [Test]
        public async Task RemoveProductFromCart()
        {
            var homePage = new HomePage(_page);
            await homePage.OpenAsync();
            var productsPage = new ProductsPage(_page);
            await productsPage.ClickProductByName("Hummingbird printed t-shirt");
            var productDetailsPage = new ProductDetailsPage(_page);
            var productAddedToCartModal = await productDetailsPage.ClickAddToCardButton();
            var cartPage  = await productAddedToCartModal.ProceedToCheckout();
            await cartPage.RemoveProductFromBasket("Hummingbird printed t-shirt");
            Assert.That(await homePage.GetProductsCountInCart(), Is.Zero);
        }

        [Test]
        public async Task ProcessOrderCheckout()
        {
            var homePage = new HomePage(_page);
            await homePage.OpenAsync();

            var loginPage = await homePage.ClickLoginButton();
            var credentials = Credentials.LoadCredentialsDataFromFile();
            await loginPage.Login(credentials.Login!, credentials.Password!);

            var productsPage = new ProductsPage(_page);
            await productsPage.ClickProductByName("Hummingbird printed t-shirt");
            var productDetailsPage = new ProductDetailsPage(_page);
            var productAddedToCartModal = await productDetailsPage.ClickAddToCardButton();
            var cartPage = await productAddedToCartModal.ProceedToCheckout();
                var checkoutPage = await cartPage.ProceedToCheckout();

            var address = new OrderAddress
            {
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St",
                City = "Anytown",
                PostalCode = "12345",
                Country = "United Kingdom"
            };

            await checkoutPage.AddressSection.FillInAddressForm(address);
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
