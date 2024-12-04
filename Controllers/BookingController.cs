using Microsoft.AspNetCore.Mvc;

namespace GolfBookingSystem.Controllers
{
    public class BookingController : Controller
    {
        // Action method for booking a slot (POST)
        [HttpPost]
        public IActionResult BookSlot(string golferName, int courseId, string selectedTime)
        {
            // Logic for booking the slot
            // Example: Save booking to database, return success message

            var message = $"Booking successful for {golferName} at {selectedTime} on Course {courseId}.";
            return Ok(message);
        }

        // Action method to fetch available slots (GET)
        [HttpGet]
        public IActionResult GetAvailableSlots(int courseId)
        {
            // Logic to fetch available slots based on courseId
            // Example: Query database or service for available slots

            var slots = new[]
            {
                new { time = "07:00 AM" },
                new { time = "07:10 AM" },
                new { time = "07:20 AM" },
                // Add more slots dynamically
            };

            return Ok(slots);
        }
    }
}
