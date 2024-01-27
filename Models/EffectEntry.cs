using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class EffectEntry
    {
        [JsonProperty("effect")]
        public string Effect { get; set; }
    }
}
