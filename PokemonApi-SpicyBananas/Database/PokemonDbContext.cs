using Microsoft.EntityFrameworkCore;
using PokemonApi_SpicyBananas.Models;

namespace PokemonApi_SpicyBananas.Database
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext()
        {

        }

        public DbSet<PokemonModel> PokemonModels { get; set; }
        public DbSet<AbilityModel> AbilityModels { get; set; }
        public DbSet<TypeModel> TypeModels { get; set; }


        // Override
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PokemonApiDb;Trusted_Connection=True;");
        }
    }
}
