using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using TravelAgentApp.Controllers;
using TravelAgentApp.Data;
using TravelAgentApp.Models;

namespace TravelAgentAppUnitTest
{
    public class BookingControllerTests
    {
        [Fact]
        public void GetBooking_ReturnOkResult()
        {
            var mockSet = new Mock<DbSet<Booking>>();
            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(m=>m.Bookings).Returns(mockSet.Object);
            var bookingController = new BookingController(mockContext.Object);

            var result = bookingController.Get();
            Assert.IsType<JsonResult>(result as JsonResult);
        }

        private List<Booking> GetTestBooking()
        {
            var testBooking = new List<Booking>();
            testBooking.Add(new Booking { Id = 1, BookingNo = "BOOK00001", BookingDate = DateTime.Now,
                BookingStartDate = DateTime.Now, BookingEndDate = DateTime.Now.AddDays(1),
                BookingStatusId = 1
            });

            return testBooking;
        }
    }
}