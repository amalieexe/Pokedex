using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class PokedexList
    {
        [JsonProperty("results")]
        public List<PokedexEntry> PokedexEntries { get; set; }
    }
}
