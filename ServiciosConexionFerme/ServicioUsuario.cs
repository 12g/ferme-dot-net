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
    public class ServicioUsuario
    {
        //METODO DE CONEXION
        public void GetResource()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var responseMessage = httpClient.GetAsync("gestion/usuarios").Result;

            string responseAsync = responseMessage.Content.ReadAsStringAsync().Result;
            var jsonObj = JsonConvert.DeserializeObject<Cliente[]>(responseAsync);

            foreach (var item in jsonObj)
            {
                Console.WriteLine(item.idCliente);
            }

            Console.WriteLine(responseAsync);
        }
    
        //SERIALIZA EL USUARIO PARA CONVERTIR A JSON
        public void GuardarUsario(Usuario per)
        {

            var json = JsonConvert.SerializeObject(per);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/usuarios/guardar", jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;

            Console.WriteLine(resp);
        }

        //LISTARCLIENTES
        public JArray ListarPersona()
        {
            string uri = "http://localhost:8082/api/gestion/personas";
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);

        }


        //LISTARCLIENTES
        public JArray ListarUsuario()
        {

            string uri = "http://localhost:8082/api/gestion/usuarios";
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);

        }
    }
}
