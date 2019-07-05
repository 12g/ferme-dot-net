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
            httpClient.BaseAddress = new Uri(UrlConexion.url);
            var responseMessage = httpClient.GetAsync("gestion/tipos_producto").Result;

            string responseAsync = responseMessage.Content.ReadAsStringAsync().Result;
            var jsonObj = JsonConvert.DeserializeObject<TipoProducto[]>(responseAsync);

            foreach (var item in jsonObj)
            {
                Console.WriteLine(item.idTipoProducto);
            }

            //Console.WriteLine(responseAsync);
        }



        //SERIALIZA TIPO PRODUCTO PARA CONVERTIR A JSON
        public void CrearTipoProducto(TipoProducto rub)
        {

            var json = JsonConvert.SerializeObject(rub);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(UrlConexion.url);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/tipos_producto/guardar", jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;

            Console.WriteLine(resp);
        }



        //LISTAR TIPOPRODUCTO
        public JArray ListaTipoProducto()
        {
            string uri = UrlConexion.url  + "gestion/tipos_producto";
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);
        }

        //LISTAR FAMILIA PRODUCTO
        public JArray ListaFAMILIAPRODUCTO()
        {
            string uri = UrlConexion.url + "gestion/familias_producto";
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);


        }
    }
}
