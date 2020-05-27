using CRUD.WebAPI.Data.Entities;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CRUD.Blazor.Data
{
    public class CervezasService
    {
        public async Task<Cerveza> GetTaskByIdAsync()
        {
            HttpClient httpClient = new HttpClient();
            var cerveza = await httpClient.GetAsync("https://localhost:44391/api/cervezas");
            var response = cerveza.Content.ReadAsStringAsync();
            Cerveza cerveza1 = JsonConvert.DeserializeObject<Cerveza>(response.Result);
            return cerveza1;
        }
    }
}
