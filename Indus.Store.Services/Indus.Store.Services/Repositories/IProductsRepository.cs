using System.Linq;
using Indus.Store.Models;

namespace Indus.Store.Services.Repositories
{
    public interface IProductsRepository
    {
        void Add(Product product);
        IQueryable<Product> GetAll();
        Product GetSingle(int ProductId);
        void Remove(Product product);
        void Update(Product product);
        bool Save();
    }
}