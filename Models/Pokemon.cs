using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
