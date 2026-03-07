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
    }
}
