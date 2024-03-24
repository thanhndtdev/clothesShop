using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJECT_PRN231.Models;

namespace PROJECT_PRN231.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProjectPrn231Context _context;

        public ProductController(ProjectPrn231Context context)
        {
            _context = context;
        }
        [HttpGet("getallproduct")]
        public IActionResult Get()
        {
            
            var product = _context.Products.ToList();
            if (product == null)
                return NotFound();
            
            return Ok(product);
        }
        [HttpGet("getproductbyid/{id}")]
        public IActionResult Get(int id)
        {

            Product product = _context.Products.SingleOrDefault( a => a.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpGet("getproductbyid/category/{category}")]
        public IActionResult Get(string category)
        {

            var product = _context.Products.Where(a =>a.Category==category).ToList();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        

    }
}
