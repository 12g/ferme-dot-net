using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppPrincipal
{
    public class Prueba
    {
        public void GetResource()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var responseMessage = httpClient.GetAsync("gestion/rubros").Result;

            Console.WriteLine("id" + responseMessage.Content.ReadAsStringAsync().Result);
        }
    }
}
