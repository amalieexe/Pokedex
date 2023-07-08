using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Ability
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("pokemon")]
        public List<Pokemon>? Pokemon { get; set; }

        [JsonProperty("is_main_series")]
        public bool? IsMainSeries { get; set; }

        [JsonProperty("effect_entries")]
        public List<EffectEntry>? EffectEntries { get; set; }
    }
}
