using Microsoft.AspNetCore.Mvc;
using PROJECT_PRN231.DTO;
using PROJECT_PRN231.Models;

namespace PROJECT_PRN231.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ProjectPrn231Context _context;
        public OrderController(ProjectPrn231Context context)
        {
            _context = context;
        }
        [HttpPost("create")]
        public IActionResult Post([FromBody] OrderDTO order)
        {
            try
            {
                Order orders = new Order()
                {
                    CustomerId = order.CustomerId,
                    OrderDate = DateTime.Now,
                    TotalAmount = order.TotalAmount
                };

                _context.Orders.Add(orders);
                return Ok(_context.SaveChanges());
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

    }
}
