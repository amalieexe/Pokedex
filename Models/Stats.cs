using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Stats
    {

        [JsonProperty("stat")]
        public Stat Stat { get; set; }

        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }

        [JsonProperty("effort")]
        public string Effort { get; set; }
    }
}
