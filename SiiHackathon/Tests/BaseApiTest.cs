using Microsoft.Playwright;

namespace SiiHackathon.Tests
{
    public class BaseApiTest : PlaywrightTest
    {
        protected readonly string API_TOKEN = "E5XH2FV5WYJA42I2XWBMUMBYJK1LF1KE";
        protected IAPIRequestContext Request = null!;

        [SetUp]
        public async Task SetUpAPITesting()
        {
            await CreateAPIRequestContext();
        }

        protected async Task CreateAPIRequestContext()
        {
            var headers = new Dictionary<string, string>();

            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(API_TOKEN+":"));
            headers.Add("Authorization", "Basic " + base64EncodedAuthenticationString);
            Request = await this.Playwright.APIRequest.NewContextAsync(new()
            {
                BaseURL = "http://54.37.131.9/api/",
                ExtraHTTPHeaders = headers          
            });
        }

        [TearDown]
        public async Task TearDownAPITesting()
        {
            await Request.DisposeAsync();
        }
    }
}
