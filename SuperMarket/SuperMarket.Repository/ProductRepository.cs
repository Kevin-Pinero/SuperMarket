using SuperMarket.Repository.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperMarket.Repository
{
    public class ProductRepository : IRepository
    {
        public async Task<List<Product>> GetAll()
        {
            return new List<Product>()
            {
                new Product{Id = 1, Label="Banane"},
                new Product{Id = 2, Label="Tomate"}
            };
        }
    }

    public interface IRepository
    {
        // todo Generic
        Task<List<Product>> GetAll();
    }
}
