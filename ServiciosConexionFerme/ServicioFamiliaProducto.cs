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
    public class ServicioFamiliaProducto
    {
        //METODO DE CONEXION
        public void GetResource()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var responseMessage = httpClient.GetAsync("gestion/familias_producto").Result;

            string responseAsync = responseMessage.Content.ReadAsStringAsync().Result;
            var jsonObj = JsonConvert.DeserializeObject<Empleado[]>(responseAsync);

            foreach (var item in jsonObj)
            {
                Console.WriteLine(item.idEmpleado);
            }

            //Console.WriteLine(responseAsync);
        }


        //SE SERIALIZA LA FAMILIA PRODUCTO PARA CONVERTIR A JSON
        public void CrearFamiliaProducto(Familia_Producto pro)
        {

            var json = JsonConvert.SerializeObject(pro);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/familias_producto/guardar", jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;

            //Console.WriteLine(resp);
            Console.WriteLine(json);
        }


        //LISTAR FAMILIA PRODUCTO
        public JArray ListarFamiliaProducto()
        {
            string uri = "http://localhost:8082/api/gestion/familias_producto";
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);
        }
    }
}
