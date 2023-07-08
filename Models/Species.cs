using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Species
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri url { get; set; }
    }
}
