﻿using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Move
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
