using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using System.Net.Http.Headers;

namespace ServiciosConexionFerme
{
   public class ServicioOrdenCompra
    {
        //METODO DE CONEXION
        public void GetResource()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var responseMessage = httpClient.GetAsync("gestion/ordenes_compra").Result;

            string responseAsync = responseMessage.Content.ReadAsStringAsync().Result;
            var jsonObj = JsonConvert.DeserializeObject<Orden_Compra[]>(responseAsync);

            foreach (var item in jsonObj)
            {
                Console.WriteLine(item.idEmpleado);
            }

            //Console.WriteLine(responseAsync);
        }

        //SE SERIALIZA EL EMPLEADO PARA CONVERTIR A JSON
        public void CrearOrdenCompra(Orden_Compra OrC)
        {

            var json = JsonConvert.SerializeObject(OrC);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/ordenes_compra/guardar", jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;

            //Console.WriteLine(resp);
            Console.WriteLine(json);
        }

    

        //OBTENER SUBDETALLE ORDEN DE COMPRA
        public List<DetalleOrdenCompra> subdetalleOrdenCompra(Orden_Compra OrC)
        {

            var json = JsonConvert.SerializeObject(OrC);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/ordenes_compra/detalles", jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;
           
            
            Console.WriteLine(resp);
            List<DetalleOrdenCompra> ListaDetalle = JsonConvert.DeserializeObject<List<DetalleOrdenCompra>>(resp);
            //Console.WriteLine(json);

            return ListaDetalle;
        }

        //LISTAR ORDEN COMPRA
        public List<Orden_Compra> ListarOrdenCompra()
        {
            string uri = "http://localhost:8082/api/gestion/ordenes_compra";
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
          return JsonConvert.DeserializeObject<List<Orden_Compra>>(s);
        }
    }
}
