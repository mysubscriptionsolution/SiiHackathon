using System.Text.Json.Serialization;

namespace SiiHackathon.Models.Requests
{
    public class Product
    {
        [JsonPropertyName("type")]
        private string Type { get; set; }
        [JsonPropertyName("names")]
        private List<Dictionary<string, string>>? Names { get; set; }

        
        public Product(string type, List<Dictionary<string, string>> names)
        {
            Type = type;
            Names = names;
        }
    }
}
