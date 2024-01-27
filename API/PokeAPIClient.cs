using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Http;
using Newtonsoft.Json;
using Pokedex.Models;

namespace Pokedex.API
{
    public class PokeAPIClient
    {
        internal readonly IHttpClientFactory _clientFactory;

        public PokeAPIClient(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        private HttpClient GetClient() => _clientFactory.CreateClient("PokeAPI");

        public async Task<PokedexList> GetPokedexList()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "pokemon?limit=2000");
            var client = GetClient();
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            PokedexList pokedexList = JsonConvert.DeserializeObject<PokedexList>(responseBody);
            return pokedexList;
        }


    }

    public class pokedexListController : Controller
    {
        private readonly PokeAPIClient _pokeAPIClient;
        internal readonly IHttpClientFactory _clientFactory;
        

        public pokedexListController(PokeAPIClient pokeAPIClient)
        {
            _pokeAPIClient = pokeAPIClient;
        }

        private HttpClient GetClient() => _clientFactory.CreateClient("PokeAPI");

        public async Task<IActionResult> Index()
        {
            var pokedexList = await _pokeAPIClient.GetPokedexList();
            return View("Views/pokemon/all/Index.cshtml", pokedexList);
        }
    }

    public class pokemonController : Controller
    {
        internal readonly IHttpClientFactory _clientFactory;

        public async Task<Pokemon> GetPokemon(string pname)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"pokemon/{pname.ToLower()}");
            var client = GetClient();
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(responseBody);
            return pokemon;
        }

        public async Task<IActionResult> Index(string pname)
        {
            var pokemon = await GetPokemon(pname);
            return View($"Views/pokemon/{pname}/Index.cshtml", pokemon);
        }

        private HttpClient GetClient() => _clientFactory.CreateClient("PokeAPI");
    }

}
