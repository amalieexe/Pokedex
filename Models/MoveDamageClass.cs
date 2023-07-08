using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class MoveDamageClass
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
