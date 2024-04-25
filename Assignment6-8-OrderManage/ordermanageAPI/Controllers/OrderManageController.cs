using Microsoft.AspNetCore.Mvc;
using OrderManage.src;


namespace OrderManage.Controllers
{

    [ApiController]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService orderService;

        public OrderController(OrderService orderService)
        {
            this.orderService = orderService;
        }
        // GET: api/Order
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            return orderService.QueryAll();
        }

        // GET: api/Order/1
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = orderService.GetById(id);
            return (order == null) ? NotFound() : order;
        }

        // POST: api/Order
        [HttpPost]
        public ActionResult<Order> AddOrder(Order order)
        {
            try
            {
                Random random= new Random();
                order.OrderId = random.Next(1,100000);
                orderService.AddOrder(order);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return order;
        }

        // PUT: api/Order/1
        [HttpPut("{id}")]
        public ActionResult<Order> updateOrder(int id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest();
            }
            try
            {
                orderService.Update(order);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/Order/1
        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(int id)
        {
            try
            {
                orderService.RemoveOrder(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }


}