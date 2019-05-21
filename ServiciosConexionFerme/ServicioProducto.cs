﻿using System;
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
    public class ServicioProducto
    {
        //METODO DE CONEXION
        public void GetResource()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var responseMessage = httpClient.GetAsync("gestion/productos").Result;

            string responseAsync = responseMessage.Content.ReadAsStringAsync().Result;
            var jsonObj = JsonConvert.DeserializeObject<Empleado[]>(responseAsync);

            foreach (var item in jsonObj)
            {
                Console.WriteLine(item.idEmpleado);
            }

            //Console.WriteLine(responseAsync);
        }

        //SE SERIALIZA EL EMPLEADO PARA CONVERTIR A JSON
        public void CrearProducto(Producto pro)
        {

            var json = JsonConvert.SerializeObject(pro);
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpContent jsonp = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = httpClient.PostAsync("gestion/productos/guardar", jsonp);
            var resp = responseMessage.Result.Content.ReadAsStringAsync().Result;

            //Console.WriteLine(resp);
            Console.WriteLine(json);
        }

      /*  public void ListarProducto()
        {
            var httpClient = new HttpClient();
            List<Producto> pro = null;
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var tareaAsincrona = httpClient.GetAsync("gestion/productos")
                .ContinueWith((json) =>
                {
                    var response = json.Result;
                    var jsonString = response.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    pro = JsonConvert.DeserializeObject<List<Producto>>(jsonString.Result);
                });

            tareaAsincrona.Wait();

            Console.Write(tareaAsincrona);
        }
        */

        public JArray GetRESTData()
        {
            string uri = "http://localhost:8082/api/gestion/productos";
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);
        }
    }
}