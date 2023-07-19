using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }
    }
}
