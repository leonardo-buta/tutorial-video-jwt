using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TutorialJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetProducts()
        {
            return Ok(new { id = 1, name = "Product 1" });
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Marketing")]
        public IActionResult GetProductsById(int id)
        {
            return Ok(new { id = 2, name = "Product 2" });
        }

        [HttpGet("3")]
        [Authorize(Roles = "Admin,TI")]
        public IActionResult DeleteProduct(int id)
        {
            return NoContent();
        }
    }
}
