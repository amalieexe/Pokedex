using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class DamageRelations
    {
        [JsonProperty("double_damage_from")]
        public List<Type>? DoubleDamageFrom { get; set; }

        [JsonProperty("double_damage_to")]
        public List<Type>? DoubleDamageTo { get; set; }

        [JsonProperty("half_damage_from")]
        public List<Type>? HalfDamageFrom { get; set; }

        [JsonProperty("half_damage_to")]
        public List<Type>? HalfDamageTo { get; set; }
    }
}
