using Microsoft.AspNetCore.Mvc;

namespace GolfBookingSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : Controller
    {
        // Action method for booking a slot (POST)
        [HttpPost("book")]
        public IActionResult BookSlot([FromBody] BookingRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Logic for booking the slot
            var message = $"Booking successful for {request.GolferName} at {request.SelectedTime} on Course {request.CourseId}.";
            return Ok(message);
        }

        // Action method to fetch available slots (GET)
        [HttpGet("slots/{courseId}")]
        public IActionResult GetAvailableSlots(int courseId)
        {
            if (courseId <= 0)
            {
                return BadRequest("Invalid course ID");
            }

            // Logic to fetch available slots based on courseId
            var slots = new[]
            {
                new { time = "07:00 AM" },
                new { time = "07:10 AM" },
                new { time = "07:20 AM" },
            };

            return Ok(slots);
        }
    }

    public class BookingRequest
    {
        public required string GolferName { get; set; }
        public int CourseId { get; set; }
        public required string SelectedTime { get; set; }
    }
}