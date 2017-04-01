namespace DbService.Models
{
    using Microsoft.Azure.Documents;
    using Newtonsoft.Json;

    public class Integration
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty(PropertyName = "apiSecret")]
        public string ApiSecret { get; set; }

        [JsonProperty(PropertyName = "nonce")]
        public string Nonce { get; set; }
    }
}