using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Type
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("pokemon")]
        public List<Pokemon>? Pokemon { get; set; }

        [JsonProperty("damage_relations")]
        public DamageRelations? DamageRelations { get; set; }

        [JsonProperty("move_damage_class")]
        public MoveDamageClass? MoveDamageClass { get; set; }

        [JsonProperty("moves")]
        public List<Move>? Moves { get; set; }
    }
}
