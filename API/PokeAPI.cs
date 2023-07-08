using Pokedex.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Pokedex.API
{

    public class PokeAPIClient
    {
        private static readonly HttpClient PokeAPI = new HttpClient() { BaseAddress = new Uri("https://pokeapi.co/api/v2/") };

        public async Task<PokedexList> GetPokedexList()
        {
            HttpResponseMessage response = await PokeAPI.GetAsync("pokemon?limit=2000");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            PokedexList pokedexList = JsonConvert.DeserializeObject<PokedexList>(responseBody);
            return pokedexList;
        }

        public class Program
        {
            public static async Task Main()
            {
                PokeAPIClient client = new PokeAPIClient();
                PokedexList pokedexList = await client.GetPokedexList();

                // You can now access the pokedexList and work with the data

                Console.WriteLine($"Count: {pokedexList.PokedexEntries.Count()}");
            }
        }
    }
}

