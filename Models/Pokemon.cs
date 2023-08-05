using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("abilities")]
        public List<Ability>? Abilities { get; set; }

        [JsonProperty("base_experience")]
        public int? BaseExperience { get; set; }

        [JsonProperty("types")]
        public List<Type>? Types { get; set; }

        [JsonProperty("stats")]
        public List<Stats>? Stats { get; set; }

        [JsonProperty("moves")]
        public List<Move>? Moves { get; set; }

        [JsonProperty("species")]
        public Species? Species { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("location_area_encounters")]
        public Uri? LocationAreaEncounters { get; set; }

        [JsonProperty("past_types")]
        public List<Type>? PastTypes { get; set; }

        [JsonProperty("held_items")]
        public List<Item>? HeldItems { get; set; }

        [JsonProperty("forms")]
        public List<Form>? Forms { get; set; }

        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }

    }
}
