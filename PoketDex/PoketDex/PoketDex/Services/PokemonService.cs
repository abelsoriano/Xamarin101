namespace PoketDex.Services
{
    using Newtonsoft.Json;
    using PoketDex.Interfaces;
    using PoketDex.Models;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class PokemonService : IPokemonService
    {
        public async Task<IEnumerable<Pokemon>> GetAllPokemonsAsync()
        {
            var result = new List<Pokemon>();

            try
            {
                var client = new HttpClient();

                var response = await client.GetStringAsync("https://listxamplefromapirestapi.azurewebsites.net/api/Employees");
                result = JsonConvert.DeserializeObject<List<Pokemon>>(response);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return result;
        }
    }
}
