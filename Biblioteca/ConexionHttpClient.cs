using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Biblioteca
{
    public class ConexionHttpClient
   {
        //METODO DE CONEXION
        public void GetResource()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var responseMessage = httpClient.GetAsync("gestion/rubros").Result;

            string responseAsync = responseMessage.Content.ReadAsStringAsync().Result;
            var jsonObj = JsonConvert.DeserializeObject<Rubro[]>(responseAsync);

            foreach (var item in jsonObj)
            {
                Console.WriteLine(item.descripcionRubro);
            }

            //Console.WriteLine(responseAsync);
        }


        //SERIALIZA EL RUBRO PARA CONVERTIR A JSON
        public void CrearRubro(Rubro rub)
        {
            var json = JsonConvert.SerializeObject(rub);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/rubros/guardar",jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;

            Console.WriteLine(resp);
        }

    }
}
