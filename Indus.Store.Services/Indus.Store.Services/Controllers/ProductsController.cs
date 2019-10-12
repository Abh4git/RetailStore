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

namespace Indus.Store.Services.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    public class ProductsController  : Controller
    {
        private IProductsRepository _productRepo;
        public ProductsController(IProductsRepository Repo)
        {
            _productRepo = Repo;
        }
        // GET api/products
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var allProducts = _productRepo.GetAll().ToList();
            var config = new AutoMapperConfig().Configure();
            var iMapper = config.CreateMapper();
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
        public void Post([FromBody]string value)
        {
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
