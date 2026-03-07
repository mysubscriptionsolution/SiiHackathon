using System.Net;
using System.Text.Json;

namespace SiiHackathon.Models.DataModels
{
    internal class Credentials
    {
        public string? Login { get; set; }
        public string? Password { get; set; }

        public static Credentials LoadCredentialsDataFromFile(string filePath = "TestData\\testData.json")
        {
            using var r = new StreamReader(filePath);
            string json = r.ReadToEnd();
            return JsonSerializer.Deserialize<Credentials>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
