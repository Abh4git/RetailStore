using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Indus.Store.WebApp.Models;
using Newtonsoft.Json;

namespace Indus.Store.WebApp.ServiceCalls
{
    public class ProductService
    {
        public ProductService()
        {

        }
            public List<Product> GetProducts()
            {
                string apiUrl = "http://localhost:60816/api/products"; 
                using (WebClient webClient = new WebClient())
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(
                        webClient.DownloadString(apiUrl)
                    );
                }
            }
            public Product AddProduct(Product newproduct)
            {
                string apiUrl = "http://localhost:60816/api/products";
                string data = JsonConvert.SerializeObject(newproduct);
                byte[] reqByte;
                byte[] responseByte;
                string responseString;
                using (WebClient webClient = new WebClient())
                {
                    
                    webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    webClient.Headers.Add(HttpRequestHeader.Accept, "application/json");
                // Code for the credentials etc
                    String serializedObject = JsonConvert.SerializeObject(data);
                    reqByte = Encoding.Default.GetBytes(serializedObject);
                    responseByte = webClient.UploadData(apiUrl, "post", reqByte);
                    responseString = Encoding.Default.GetString(responseByte);
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<Product> (
                        responseString
                    );

                    
                }
         
        }
        
    }
}
