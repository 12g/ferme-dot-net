using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Biblioteca;

namespace AppPrincipal
{
    public class Prueba
    {
        
        public void GetResource()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            var responseMessage = httpClient.GetAsync("gestion/rubros").Result;

            Console.WriteLine("id" + responseMessage.Content.ReadAsStringAsync().Result);
        }

        
        
         /*
        //Crear e inicializar HttpClient
        //HttpClient está diseñado para ser instanciado una vez y 
        //reutilizado durante toda la vida de una aplicación.
        public static HttpClient HttpClient = new HttpClient();

        //LISTADO RUBRO
        public static void ShowRubro(Rubro rub)
        {
            Console.WriteLine($"Codigo: {rub.IdRubro}\tDescripcion:" + $"{rub.Descripcion}");
        }


        //El método GetAsync envía la solicitud HTTP GET. Cuando el método se completa, 
        //devuelve un HttpResponseMessage que contiene la respuesta HTTP. 
        //Si el código de estado en la respuesta es un código de éxito, 
        //el cuerpo de la respuesta contiene la representación JSON de un producto.
        //Llame a ReadAsAsync para deserializar la carga JSON a un Productinstancia. 
        //El método ReadAsAsync es asíncrono porque el cuerpo de la respuesta puede ser
        //arbitrariamente grande

        //Enviar una solicitud GET para recuperar un recurso
        static async Task<Rubro> GetRubroAsync(string Path)
        {
            Rubro rubr = null;
            HttpResponseMessage response = await HttpClient.GetAsync(Path);

            if (response.IsSuccessStatusCode)
            {
                rubr = await response.Content.ReadAsAsync<Rubro>();
            }
            return rubr;
        }

        //CREAR RUBRO
         static async Task<Uri> CreateRubroAsync(Rubro rub)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync($"gestion/rubros", rub);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        //ACTUALIZAR RUBRO
        static async Task<Rubro> UpdateRubroAsync(Rubro rub)
        {
            HttpResponseMessage response = await HttpClient.PutAsJsonAsync($"gestion/rubros{rub.IdRubro}", rub);
            response.EnsureSuccessStatusCode();

            // Deserializar el producto actualizado desde el cuerpo de la respuesta.
            rub = await response.Content.ReadAsAsync<Rubro>();
            return rub;
        }

        //ELIMINAR RUBRO
        static async Task<HttpStatusCode> DeleteRubrotAsync(int id)
        {
            HttpResponseMessage response = await HttpClient.DeleteAsync($"gestion/rubros{id}");
            return response.StatusCode;
        }

        private static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }
      

        static async Task RunAsync()
        {
            // Update port # in the following line.
            HttpClient.BaseAddress = new Uri("http://localhost:8082/api/");
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("gestion/rubros"));


            try
            {
                // Create a new product
                Rubro rub = new Rubro
                {
                    IdRubro = 0,
                    Descripcion = string.Empty,

                };

                var url = await CreateRubroAsync(rub);
                //Console.WriteLine($"Created at {url}");

                // Get the product
                rub = await GetRubroAsync(url.PathAndQuery);
                //ShowRubro(rub);
            
                
                
                // Update the product
                Console.WriteLine("Updating price...");
                        rub.Descripcion = "";
                        await UpdateRubroAsync(rub);

                // Get the updated product
                rub = await GetRubroAsync(url.PathAndQuery);
                ShowRubro(rub);

                // Delete the product
                var statusCode = await DeleteRubrotAsync(rub.IdRubro);
                Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
             
        }*/
        
    }
}
 
