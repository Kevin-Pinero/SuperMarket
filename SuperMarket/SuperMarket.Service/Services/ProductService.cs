using SuperMarket.Repository;
using SuperMarket.Service.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository ProductRepository;

        public ProductService(IRepository repo)
        {
            ProductRepository = repo;
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var products = await ProductRepository.GetAll();

            return products.Select(x=> new ProductDto(x)).ToList();
        }
    }

    public interface IProductService
    {
        Task<List<ProductDto>> GetAll();
    }
}
