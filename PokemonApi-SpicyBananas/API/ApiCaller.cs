namespace PokemonApi_SpicyBananas.API
{
    public class ApiCaller
    {
        public HttpClient Client { get; set; }

        public ApiCaller()
        {
            Client = new();

            Client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
        }

        //public async Task<Root> MakeCall(string url)
        //{
        //    HttpResponseMessage response = await Client.GetAsync(url);
        //}
    }
}
