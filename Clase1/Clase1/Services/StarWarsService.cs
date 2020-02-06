using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using System.ComponentModel;

namespace Clase1.Services
{
    public class StarWarsService
    {
        HttpClient cliente = new HttpClient();

        public async Task<List<People>> GetPeoplesAsync()
        {
            string response = await cliente.GetStringAsync(new Uri("https://swapi.co/api/people/"));

            RequestResult personajes = JsonConvert.DeserializeObject<RequestResult>(response);

            return personajes.results;
        }
    }

    public class RequestResult
    {
        public List<People> results { get; set; }
    }

    public class People
    {
        public string name { get; set; }
        public string height { get; set; }
        public string mass { get; set; }
        public string hair_color { get; set; }
        public string skin_color { get; set; }
        public string eye_color { get; set; }
        public string birth_year { get; set; }
        public string gender { get; set; }
        public string homeworld { get; set; }
        public string url { get; set; }
    }
}
