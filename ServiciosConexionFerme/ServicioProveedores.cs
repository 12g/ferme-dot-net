using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using System.Net.Http.Headers;

namespace ServiciosConexionFerme
{
   public class ServicioProveedores
    {
        //METODO DE CONEXION
        public void GetResource()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var responseMessage = httpClient.GetAsync("gestion/proveedores").Result;

            string responseAsync = responseMessage.Content.ReadAsStringAsync().Result;
            var jsonObj = JsonConvert.DeserializeObject<Proveedor[]>(responseAsync);

            foreach (var item in jsonObj)
            {
                Console.WriteLine(item.idProveedor);
            }

            //Console.WriteLine(responseAsync);
        }


        //SERIALIZA EL PROVEEDOR PARA CONVERTIR A JSON
        public void CrearProveedor(Proveedor Pro)
        {

            var json = JsonConvert.SerializeObject(Pro);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/proveedores/guardar", jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;

            Console.WriteLine(resp);
        }
    }
}
