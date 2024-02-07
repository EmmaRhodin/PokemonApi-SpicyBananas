using Microsoft.AspNetCore.Mvc.RazorPages;
using PokemonApi_SpicyBananas.API;
using PokemonApi_SpicyBananas.Models;

namespace PokemonApi_SpicyBananas.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<PokemonModel> PokemonModels { get; set; }
        public string? ErrorMessage { get; set; }

        public async void OnGet()
        {
            try
            {
                Root result = await new ApiCaller().MakeCall("pokemonModel");

                PokemonModels = result.Pokemons;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }


    }
}
