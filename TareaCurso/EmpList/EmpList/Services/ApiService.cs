using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using EmpList.Interfaces;
using EmpList.Models;
using Newtonsoft.Json;

namespace EmpList.Services
{
    public class ApiService : IApiService
    {
        public async Task<IEnumerable<Beer>> GetAllBeerss()
        {
            var result = new List<Beer>();

            try
            {
                var client = new HttpClient();

                var response = await client.GetStringAsync("https://api.punkapi.com/v2/beers");
                result = JsonConvert.DeserializeObject<List<Beer>>(response);

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
