using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Indus.Store.WebApp.Models;
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
        
    }
}
