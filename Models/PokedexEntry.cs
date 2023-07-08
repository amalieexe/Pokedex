using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class PokedexEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri url { get; set; }
    }
}
