using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Indus.Store.Models;
using Indus.Store.DataObjects;
using AutoMapper;
using Indus.Store.Services.Repositories;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;

namespace Indus.Store.Services.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    public class ProductsController  : Controller
    {
        private IProductsRepository _productRepo;
        private MapperConfiguration _config;
        public ProductsController(IProductsRepository Repo)
        {
            _productRepo = Repo;
            _config = new AutoMapperConfig().Configure();

        }
        // GET api/products
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var allProducts = _productRepo.GetAll().ToList();
            var iMapper = _config.CreateMapper();
            var allProductsDTO = iMapper.Map<ICollection<Product>, ICollection<ProductDTO>>(allProducts);
            return Ok(allProductsDTO);
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult AddProduct([FromBody] dynamic data)
        {
            var config = new AutoMapperConfig().Configure();
            var iMapper = _config.CreateMapper();
            var product = JsonConvert.DeserializeObject(data);
            //ProductDTO product = (ProductDTO)JsonConvert.DeserializeObject(data);
            Product productToAdd = new Product {product_name=product["product_name"],product_description=product["product_description"], product_price=product["product_price"] };
            _productRepo.Add(productToAdd);
            bool result = _productRepo.Save();
            if (!result)
            {
                return new StatusCodeResult(500);
            }
            return Ok(iMapper.Map<ProductDTO>(productToAdd));
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

       
    }

}
