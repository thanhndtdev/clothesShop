using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJECT_PRN231.DTO;
using PROJECT_PRN231.Models;
using static System.Net.Mime.MediaTypeNames;

namespace PROJECT_PRN231.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ProjectPrn231Context _context;
        public CartController(ProjectPrn231Context context)
        {
            _context = context;
        }
        [HttpPost("create")]
        public IActionResult Post([FromBody] CartDTO cartdto)
        {
            try
            {
                Cart cart = new Cart()
                {
                    UserId = cartdto.UserId,
                    ProductId = cartdto.ProductId,
                    Quantity = cartdto.Quantity
                };
                _context.Carts.Add(cart);
                return Ok(_context.SaveChanges());
            } catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        [HttpGet("getListCartByUserId/{id}")]
        public IActionResult Get(int id)
        {
            List<ListProductDTO> list = new List<ListProductDTO>();
            var cart = _context.Carts.Where(a => a.UserId == id).ToList();
            if (cart == null)
            {
                return NotFound();
            }
            else
            {
                foreach (var item in cart)
                {
                    Product product = new Product();
                    product = _context.Products.SingleOrDefault(a => a.Id == item.ProductId);
                    if (product != null)
                    {
                        ListProductDTO productDTO = new ListProductDTO()
                        {
                            Id = product.Id,
                            Title = product.Title,
                            CategoryId = product.CategoryId,
                            Price = product.Price,
                            qty = item.Quantity,
                            Image = product.Image,
                            Category = product.Category,
                            Description = product.Description
                        };
                        list.Add(productDTO);

                    }

                }
            }
            if (list.Count > 0)
            {
                return Ok(list);
            } else { return BadRequest(); }
        }
        [HttpPost]
        
        public IActionResult AddToCart([FromBody] List<CartDTO> carts)
        {
            // Xử lý dữ liệu ở đây
            foreach (var product in carts)
            {
                Console.WriteLine(product);
            }

            // Trả về một phản hồi thành công hoặc thông báo khác nếu cần
            return Ok("Products added to cart successfully.");
        } }
}
