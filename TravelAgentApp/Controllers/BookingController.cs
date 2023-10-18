using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelAgentApp.Data;
using TravelAgentApp.Models;

namespace TravelAgentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        
        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var result = _context.Bookings.ToList();

            return new JsonResult(Ok(result));
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var result = _context.Bookings.Find(id);

            if (result == null)
            {
                return new JsonResult(NotFound());
            }

            return new JsonResult(Ok(result));
        }

        [HttpPost]
        public JsonResult CreateUpdate(Booking booking)
        {
            if(booking.Id == 0)
            {
                var productInv = _context.Inventories.Where(x => x.ProductId == booking.ProductId &&
                    x.StartValidDate <= booking.BookingStartDate && x.EndValidDate >= booking.BookingStartDate &&
                    x.StartValidDate <= booking.BookingEndDate && x.EndValidDate >= booking.BookingEndDate)
                    .OrderBy(x=>x.InventoryDate).LastOrDefault();

                if(productInv != null)
                {
                    //check qty availability
                    var inventoryQty = productInv.Qty;
                    var bookedProductQty = _context.Bookings.Where(x => x.ProductId == booking.ProductId &&
                        productInv.StartValidDate <= x.BookingStartDate && productInv.EndValidDate >= x.BookingStartDate &&
                        productInv.StartValidDate <= x.BookingEndDate && productInv.EndValidDate >= x.BookingEndDate
                        && x.BookingStatusId == 2).Count();
                    bool isAvailable = inventoryQty - bookedProductQty >= booking.Qty;

                    if (isAvailable)
                    {
                        _context.Bookings.Add(booking);
                        productInv.Qty = productInv.Qty - 1; //consume inventory qty

                        _context.SaveChanges();
                        return new JsonResult(Ok());
                    }
                }

                return new JsonResult(UnprocessableEntity());
            }

            return new JsonResult(Ok());
        }
    }
}
