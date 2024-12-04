using System.ComponentModel.DataAnnotations;

namespace GolfBookingSystem.Models
{
    public class BookingViewModel
    {
        // Properties representing data needed for booking view
        public string GolferName { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public string SelectedTime { get; set; } = string.Empty;
        // Add more properties as needed
    }
}
