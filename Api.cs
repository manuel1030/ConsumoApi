using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Security.Cryptography;
namespace ConsumoApi
{
    internal class Api
    {
        static string apiUrl = "https://dummyjson.com/";
        public static void add(ref string mensaje, product paramss)
        {
            var apiurls = apiUrl + "products/add";

            var productData = new Dictionary<string, object>
            {
               
                { "title", paramss.Title},
                { "description", paramss.Description },
                { "price", paramss.Price },
                { "discountPercentage", paramss.DiscountPercentage},
                { "rating",  paramss.Rating },
                { "stock",  paramss.Stock },
                { "brand", paramss.Brand },
                { "category", paramss.Category },
                { "thumbnail", paramss.Thumbnail },
                { "images", new List<string> { $"path/to/{paramss.Img0}", $"path/to/{paramss.Img1}", $"path/to/{paramss.Img2}", $"path/to/{paramss.Img3}" } },
                /* otros datos del producto */
            };


            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(productData);

                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    HttpResponseMessage response =  client.PostAsync(apiurls, content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                      
                        mensaje = "ok";
                    }
                    else
                    {
                        mensaje = $"Error en la solicitud: {response.StatusCode} - {response.ReasonPhrase}";
                        
                    }
                }
                catch (Exception ex)
                {
                    mensaje = $"Error: {ex.Message}";
                }
            }
        }

        public static void getResponse(ref product product, String url)
        {

            var api = apiUrl + url;
            // Crear una instancia de HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Realizar una solicitud GET a la API
                    HttpResponseMessage response = client.GetAsync(api).Result;

                    // Verificar si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {

                        string data = response.Content.ReadAsStringAsync().Result;
                        JObject json = JObject.Parse(data);

                        // Verificar si el objeto contiene un array en lugar de un objeto

                        product.Title = json["title"].ToString();
                        product.Brand = json["brand"].ToString();
                        product.Description = json["description"].ToString();
                        product.Price = json["price"].ToString() ;
                        product.DiscountPercentage = json["discountPercentage"].ToString();
                        product.Rating = json["rating"].ToString();
                        product.Stock = json["stock"].ToString();
                        product.Brand = json["brand"].ToString();
                        product.Category = json["category"].ToString();
                        product.Thumbnail = json["thumbnail"].ToString();
                        JToken dataArray = json["images"];
                        if (dataArray is JArray)
                        {
                            product.Img0 = dataArray[0].ToString();
                            product.Img1 = dataArray[1].ToString();
                            product.Img2 = dataArray[2].ToString();
                            product.Img3 = dataArray[3].ToString();
                           
                        }
                        else
                        {
                            Console.WriteLine("La propiedad 'data' no es un array en el JSON recibido.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Error en la solicitud: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public static void Response(ref DataTable dt,  String url)
        {

            var api = apiUrl  + url;
            // Crear una instancia de HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Realizar una solicitud GET a la API
                    HttpResponseMessage response =  client.GetAsync(api).Result;

                    // Verificar si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {
                        
                        string data =  response.Content.ReadAsStringAsync().Result;
                        JObject json = JObject.Parse(data);

                        // Verificar si el objeto contiene un array en lugar de un objeto
                        JToken dataArray = json["products"];
                        if (dataArray is JArray)
                        {
                            
                             dt = JsonConvert.DeserializeObject<DataTable>(dataArray.ToString());

                        }
                        else
                        {
                            Console.WriteLine("La propiedad 'data' no es un array en el JSON recibido.");
                        }
                      

                    }
                    else
                    {
                        Console.WriteLine($"Error en la solicitud: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        public static void DeleteResponse(ref DataTable dt, String url)
        {

            var api = apiUrl + url;
            // Crear una instancia de HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Realizar una solicitud GET a la API
                    HttpResponseMessage response = client.DeleteAsync(api).Result;

                    // Verificar si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {

                        string data = response.Content.ReadAsStringAsync().Result;
                        JObject json = JObject.Parse(data);

                        // Verificar si el objeto contiene un array en lugar de un objeto
                        JToken dataArray = json["products"];
                        if (dataArray is JArray)
                        {

                            dt = JsonConvert.DeserializeObject<DataTable>(dataArray.ToString());

                        }
                        else
                        {
                            Console.WriteLine("La propiedad 'data' no es un array en el JSON recibido.");
                        }


                    }
                    else
                    {
                        Console.WriteLine($"Error en la solicitud: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        public static void responseLogin(ref String responseMensaje,  String user, String password)
        {

             var api =  apiUrl + "auth/login";


            var requestData = new
            {
                username = user,
                password = password,

            };


            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Convertir los datos a formato JSON
                    string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);

                    // Crear el contenido de la solicitud POST
                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    // Realizar una solicitud POST a la API de autenticación
                    HttpResponseMessage response =  client.PostAsync(api, content).Result;

                    // Verificar si la solicitud fue exitosa (código de estado 2xx)
                    if (response.IsSuccessStatusCode)
                    {

                        string responseData =  response.Content.ReadAsStringAsync().Result;

    
                        Console.WriteLine(responseData);
                    }
                    else
                    {
                        responseMensaje = $"Error en la solicitud: {response.StatusCode} - {response.ReasonPhrase}";
                    }
                }
                catch (Exception ex)
                {
                    responseMensaje = $"Error: {ex.Message}";
                }
            }
        }
        static DataTable ConvertJsonToDataTable(string jsonString)
        {
            JArray jsonArray = JArray.Parse(jsonString);

            DataTable dataTable = new DataTable();

            // Crear columnas basadas en las propiedades del primer objeto en el JSON
            foreach (JToken token in jsonArray.First())
            {
                DataColumn column = new DataColumn(token.Path, typeof(string));
                dataTable.Columns.Add(column);
            }

            // Agregar filas al DataTable
            foreach (JObject jsonObj in jsonArray)
            {
                DataRow row = dataTable.NewRow();
                foreach (JProperty prop in jsonObj.Properties())
                {
                    row[prop.Name] = prop.Value.ToString();
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

    }
}
