using Microsoft.AspNetCore.Mvc.RazorPages;
using PokemonApi_SpicyBananas.API;
using PokemonApi_SpicyBananas.Models;

namespace PokemonApi_SpicyBananas.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public enum Pokemons
        {
            Abra,
            Aerodactyl,
            Alkazam,
            Arbook,
            Arvanine,
            Articuno,
            Beedrill,
            Bellsprout,
            Blastoise,
            Bublasaur,
            Butterfree,
            Caterpie,
            Chansey,
            Charizard,
            Charmander,
            Charmeleon,
            Clefable,
            Clefairy,
            Cloyster,
            Cubone,
            Dewgong,
            Diglett,
            Ditto,
            Dodrio,
            Doduo,
            Dragonair,
            Dragonite,
            Dratini,
            Drowzee,
            Dugtrio,
            Eevee,
            Ekans,
            Electabuzz,
            Electrode,
            Exeggcute,
            Exeggutor,
            Fearow,
            Flareon,
            Gastly,
            Gengar,
            Geodude,
            Gloom,
            Golbat,
            Goldeen,
            Golduck,
            Golem,
            Graveler,
            Grimer,
            Growlithe,
            Gyarados,
            Haunter,
            Hitmonchan,
            Hitmonlee,
            Horsea,
            Hypno,
            Ivysaur,
            Jigglypuff,
            Jolteon,
            Jynx,
            Kabuto,
            Kabutops,
            Kadabra,
            Kakuna,
            Kangaskhan,
            Kingler,
            Koffing,
            Krabby,
            Lapras,
            Lickitung,
            Machamp,
            Machoke,
            Machop,
            Magikarp,
            Magmar,
            Magnemite,
            Magneton,
            Mankey,
            Marowak,
            Meowth,
            Matapod,
            Mew,
            Mewtwo,
            Moltres,
            Muk,
            Nidoking,
            Nidoqueen,
            Nidoran,
            Nidorina,
            Nidorino,
            Ninetales,
            Oddish,
            Omanyte,
            Omastar,
            Onix,
            Paras,
            Parasect,
            Persian,
            Pidgeot,
            Pidgeotto,
            Pidgey,
            Pikachu,
            Pinsir,
            Poliwag,
            Poliwhirl,
            Poliwrath,
            Ponyta,
            Porygon,
            Primeape,
            Psyduck,
            Raichu,
            Rapidash,
            Raticate,
            Rattata,
            Rhydon,
            Rhyhorn,
            Sandshrew,
            Sandslash,
            Scyther,
            Seadra,
            Seaking,
            Seel,
            Shellder,
            Slowbro,
            Slowpoke,
            Snorlax,
            Spearow,
            Squirtle,
            Starmite,
            Staryu,
            Tangela,
            Tauros,
            Tentacool,
            Tentacruel,
            Vaporeon,
            Venomoth,
            Venonat,
            Venusaur,
            Victreebel,
            Vileplume,
            Voltorb,
            Vulpix,
            Wartortle,
            Weedle,
            Weepinbell,
            Weezing,
            Wigglytuff,
            Zapdos,
            Zubat
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public Root? Pokemon { get; set; }
        public string? ErrorMessage { get; set; }
        public async Task OnSelect()
        {
            string selectedPokemon = "bulbasaur";
            try
            {
                Root result = await new ApiCaller().MakeCall(selectedPokemon);

                Pokemon = result;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
        public async Task OnGet()
        {
            try
            {
                Root result = await new ApiCaller().MakeCall("charmander");

                Pokemon = result;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }


    }
}
