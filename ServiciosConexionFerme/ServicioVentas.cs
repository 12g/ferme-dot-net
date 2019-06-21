using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ServiciosConexionFerme
{
   public class ServicioVentas
    {
        //METODO DE CONEXION
        public void GetResource()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var responseMessage = httpClient.GetAsync("gestion/ventas").Result;

            string responseAsync = responseMessage.Content.ReadAsStringAsync().Result;
            var jsonObj = JsonConvert.DeserializeObject<Venta[]>(responseAsync);

            foreach (var item in jsonObj)
            {
                Console.WriteLine(item.idVenta);
            }

            //Console.WriteLine(responseAsync);
        }

        //SE SERIALIZA LA VENTA PARA CONVERTIR A JSON
        public void CrearVenta(Venta Vent)
        {

            var json = JsonConvert.SerializeObject(Vent);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/ventas/guardar", jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;

            //Console.WriteLine(resp);
            Console.WriteLine(json);
        }

      

        //OBTENER SUBDETALLE VENTA
        public List<Detalle_Venta> subdetalleventa(Venta Vent)
        {

            var json = JsonConvert.SerializeObject(Vent);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/ventas/detalles", jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;
           

            Console.WriteLine(resp);
            List<Detalle_Venta> ListaDetalle = JsonConvert.DeserializeObject<List<Detalle_Venta>>(resp);
            //Console.WriteLine(json);

            return ListaDetalle;
        }

        //LISTAR VENTA
        public List<Venta> ListarVenta()
        {
            string uri = "http://localhost:8082/api/gestion/ventas";
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Venta>>(s);
        }
    }
}
