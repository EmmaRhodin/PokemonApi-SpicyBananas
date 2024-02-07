using Newtonsoft.Json;

namespace PokemonApi_SpicyBananas.Models
{
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
    public class Sprites
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public object BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class Form
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Root
    {

        [JsonProperty("base_experience")]
        public int? BaseExperience { get; set; }

        [JsonProperty("forms")]
        public List<Form> Forms { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("past_abilities")]
        public List<object> PastAbilities { get; set; }

        [JsonProperty("past_types")]
        public List<object> PastTypes { get; set; }

        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }
    }
}
