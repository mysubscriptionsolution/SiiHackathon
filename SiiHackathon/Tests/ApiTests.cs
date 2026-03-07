namespace SiiHackathon.Tests
{
    public class ApiTests : BaseApiTest
    {
        [Test]
        public async Task GetProducts_ReturnOkStatus()
        {

            var response = await Request.GetAsync(Const.ApiUrls.GetProducts);
            var responseBody = await response.TextAsync();
             Console.WriteLine(responseBody);
             Assert.That(response.Status, Is.EqualTo(200), "API should return 200 OK");
        }
    }
}
