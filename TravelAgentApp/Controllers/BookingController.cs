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
                List<Inventory> productInventories = _context.Inventories.Where(x => x.ProductId == booking.ProductId && x.Qty > 0).ToList();

                if(productInventories.Count > 0)
                {
                    var tempBookingQty = booking.Qty;

                    foreach (var inv in productInventories)
                    {
                        bool isStartDateValid = inv.StartValidDate <= booking.BookingStartDate;
                        bool isEndDateValid = inv.EndValidDate >= booking.BookingEndDate;
                        var bookedProducts = _context.Bookings.Where(x => x.ProductId == booking.ProductId &&
                                (inv.StartValidDate <= x.BookingStartDate && inv.EndValidDate >= x.BookingEndDate) &&
                                x.BookingStatusId == 2).ToList();
                        var bookedProducstQty = bookedProducts.Sum(x => x.Qty);

                        if(bookedProducstQty < inv.Qty)
                        {
                            if (isStartDateValid && !isEndDateValid) tempBookingQty = Convert.ToInt32(inv.EndValidDate.Value.Subtract(booking.BookingStartDate).TotalDays);
                            if (!isStartDateValid && isEndDateValid) tempBookingQty = Convert.ToInt32(booking.BookingEndDate.Subtract(inv.StartValidDate.Value).TotalDays);

                            if (tempBookingQty > 0)
                            {
                                var bookedQty = tempBookingQty;

                                if (productInventories.Sum(x => x.Qty) >= tempBookingQty)
                                {
                                    if (tempBookingQty >= inv.Qty)
                                    {
                                        tempBookingQty = tempBookingQty - inv.Qty;
                                        inv.Qty = inv.Qty - bookedQty;
                                    }
                                    else
                                    {
                                        inv.Qty = inv.Qty - booking.Qty;
                                    }
                                }
                            }
                        }

                        _context.Bookings.Add(booking);
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
