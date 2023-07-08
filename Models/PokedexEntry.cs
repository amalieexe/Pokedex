using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class PokedexEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
