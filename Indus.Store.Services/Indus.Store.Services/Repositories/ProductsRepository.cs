using Indus.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Indus.Store.DataObjects;

namespace Indus.Store.Services.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private RetailStoreContext _context;
        public ProductsRepository(RetailStoreContext retailStoreContext)
        {
            _context = retailStoreContext;
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetSingle(int ProductId)
        {
            return _context.Products.FirstOrDefault(x=> x.product_id == ProductId);
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
        }

        public void Remove(Product product)
        {
            _context.Products.Remove(product);
           
        }
        
        public bool Save()
        {
            return _context.SaveChanges() >=0;
        }
    }
}
