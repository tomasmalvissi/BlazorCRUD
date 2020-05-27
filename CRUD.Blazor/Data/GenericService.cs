using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CRUD.Blazor.Data
{
    public class GenericService<T> where T : class
    {
        public static async Task<T> GetTaskByIdAsync(int Id, string Url)
        {
            HttpClient httpClient = new HttpClient();
            var request = await httpClient.GetAsync(Url + Id.ToString());
            var response = request.Content.ReadAsStringAsync();
            T Salida = JsonConvert.DeserializeObject<T>(response.Result);
            return Salida;
        }
    }
}