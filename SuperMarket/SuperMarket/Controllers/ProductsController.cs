using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Service.Services;
using SuperMarket.WebAPI.Contracts;

namespace SuperMarket.WebAPI.Controllers
{
    [Route("api/Products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService ProductService;

        public ProductsController(IProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await ProductService.GetAll();

                return Ok(result.Select(x => new ProductResponse(x))); ;
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            } 
        }
    }
}