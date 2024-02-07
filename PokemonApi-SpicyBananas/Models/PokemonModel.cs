using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonApi_SpicyBananas.Models
{
    public class Root
    {
        public List<PokemonModel>? Pokemons { get; set; }

    }

    public class PokemonModel
    {
        // Våra Pokemon properties

        [Key]
        [Column("id")] // Id är våran Primary Key
        public int Id { get; set; }

        [Column("name")] // Namnet på pokemonen
        public string Name { get; set; } = null!;

        [Column("height")] // Hur lång är vår pokemon
        public float? Height { get; set; }

        [Column("weight")] // Hur mycket väger vår pokemon
        public float? Weight { get; set; }


        [Column("spriteUrl")] // URL länk till Sprite
        public string? SpriteUrl { get; set; }

        [Column("spriteImage")] // Hämta bilden
        public byte[]? SpriteImage { get; set; }


        // Vilka typer har våran pokemon
        public List<TypeModel>? Types { get; set; }

        // Vilka abilities har vår pokemon
        public List<AbilityModel>? Abilities { get; set; }

    }
}
