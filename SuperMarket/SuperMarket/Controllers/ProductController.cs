using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Contracts;

namespace SuperMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public async Task<IActionResult> Get()
        {
            return Ok(new Product());
        }
    }
}