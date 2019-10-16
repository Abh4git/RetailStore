using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Indus.Store.WebApp.Models;
using Indus.Store.WebApp.ServiceCalls;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Indus.Store.WebApp
{
    public class HomeController : Controller
    {
        private readonly IOptions<MySettingsModel> appSettings;
        private ProductService _productService;

        public HomeController(IOptions<MySettingsModel> app)
        {
            appSettings = app;
            _productService = new ProductService();

            //ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
        }


        /*[Route("Home/Index")]
        public async Task<IActionResult> Index()
        {
            var data = await ApiClientFactory.Instance.GetProducts();
            ViewData["MyProduct"] = data[0];
            return View();
        }*/

        public  IActionResult Index()
        {
            /*Product test = new Product() { product_id =1, product_name="Test"};
            ViewData["MyProduct"] = test;
            return View(test);*/

            
            //ViewData["MyProduct"] = _productService.GetProducts();
            List<Product> productsList = _productService.GetProducts();
            return View(productsList);

        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            /*Product test = new Product() { product_id =1, product_name="Test"};
            ViewData["MyProduct"] = test;
            return View(test);*/
            return View();

        }

        [HttpPost, ValidateAntiForgeryToken]
        [Route("Home/AddProduct")]
        public JsonResult AddProduct([FromBody] Product product)
        {
            //Product test = new  Product() { product_id =1, product_name="Test"};
            //ViewData["MyProduct"] = test;
            //return View(test);*/
            //return Ok();
            Product productAdded = _productService.AddProduct(product);
            return Json(productAdded);

        }
        [HttpPost]
        public IActionResult Post(Product model)
        {
            /*Product test = new Product() { product_id =1, product_name="Test"};
            ViewData["MyProduct"] = test;
            return View(test);*/
            return Ok();

        }
        /*private async Task<JsonResult> SaveUser()
        {
            var model = new UsersModel()
            {
                Id = 0,
                Name = "Lionel Messi",
                EmailId = "iam@messi.com",
                Mobile = "4234235423",
                Address = "Barcelona",
                IsActive = true
            };
            var response = await ApiClientFactory.Instance.SaveUser(model);
            return Json(response);
        }*/

        // GET: /<controller>/
        /*public async Task<IActionResult> Index()
        {
            string apiUrl = "localhost:60816/api/products";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(data);

                }


            }
            return View();
        }*/
    }
}
