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
    public class ServicioTipoProducto
    {
        //METODO DE CONEXION
        public void GetResource()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var responseMessage = httpClient.GetAsync("gestion/tipos_producto").Result;

            string responseAsync = responseMessage.Content.ReadAsStringAsync().Result;
            var jsonObj = JsonConvert.DeserializeObject<TipoProducto[]>(responseAsync);

            foreach (var item in jsonObj)
            {
                Console.WriteLine(item.idTipoProducto);
            }

            //Console.WriteLine(responseAsync);
        }

        //LISTAR TIPOPRODUCTO
        public JArray ListaTipoProducto()
        {
            string uri = "http://localhost:8082/api/gestion/tipos_producto";
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);

           
        }
    }
}
