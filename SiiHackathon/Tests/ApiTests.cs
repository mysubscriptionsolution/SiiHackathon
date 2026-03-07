using Newtonsoft.Json;
using SiiHackathon.Models.Requests;
using System.Collections;
using System.IO;
using System.Net;
using System.Text.Json;

namespace SiiHackathon.Tests
{
    public class ApiTests : BaseApiTest
    {
        [TestCase(HttpStatusCode.Created)]
        public async Task CreateProduct_WithValidData_ReturnCreated(HttpStatusCode expectedStatusCode)
        {
            //Arrange
            var names = new List<Dictionary<string, string>>
                {
                    new Dictionary<string, string>
                    {
                        { "en", "Test Product" },
                        { "pl", "Produkt Testowy" }
                    }
                };
            var type = "TestProduct";
            var requestBody = new Product(type, names);
           // var requestBodyJson = JsonConvert.SerializeObject(requestBody);

            //Act
            await Request.PostAsync(Const.ApiUrls.Products, new() { DataObject =  requestBody});
                var response = await Request.PostAsync(Const.ApiUrls.Products);
                var responseBody = await response.TextAsync();
                Console.WriteLine(responseBody);

            //Assert
            Assert.That(response.Status, Is.EqualTo((int)expectedStatusCode), "API should return 201 Created");
        }

        [TestCase(HttpStatusCode.Created)]
        public async Task GetProduct_ReturnOk(HttpStatusCode expectedStatusCode)
        {
            //Arrange
           
            //Act
            
            var response = await Request.GetAsync(Const.ApiUrls.Products);

            Console.WriteLine(response);

            //Assert
            Assert.That(response.Status, Is.EqualTo((int)expectedStatusCode), "API should return 201 Created");
        }
    }
}
