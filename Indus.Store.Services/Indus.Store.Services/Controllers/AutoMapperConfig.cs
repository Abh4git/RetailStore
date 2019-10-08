using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Indus.Store.DataObjects;
using Indus.Store.Models;
namespace Indus.Store.Services.Controllers
{
    public class AutoMapperConfig
    {
        //public static void config()
        //{
        //    Mapper.Initialize( cfg => cfg.CreateMap<Author,AuthorDTO>());
        //}

        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                //way one 
                cfg.CreateMap<Product, ProductDTO>();
            }
           );

            return config;
        }
    }
}
