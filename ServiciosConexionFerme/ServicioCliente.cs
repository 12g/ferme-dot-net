using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using Newtonsoft.Json;

namespace ServiciosConexionFerme
{
    public class ServicioCliente
    {
        //METODO DE CONEXION
        public void GetResource()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var responseMessage = httpClient.GetAsync("gestion/clientes").Result;

            string responseAsync = responseMessage.Content.ReadAsStringAsync().Result;
            var jsonObj = JsonConvert.DeserializeObject<Cliente[]>(responseAsync);

            foreach (var item in jsonObj)
            {
                Console.WriteLine(item.idCliente);
            }

            Console.WriteLine(responseAsync);
        }


        //SERIALIZA EL CLIENTE PARA CONVERTIR A JSON
        public void CrearCliente(Cliente cli)
        {

            var json = JsonConvert.SerializeObject(cli);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/clientes/guardar", jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;

            Console.WriteLine(resp);
        }

        public void EliminarCliente(Cliente Cli)
        {
            var json = JsonConvert.SerializeObject(Cli);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/clientes/borrar", jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;
        }

    }
}
