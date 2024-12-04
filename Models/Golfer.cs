namespace GolfBookingSystem.Models
{
    public class Golfer
    {
        public int Id { get; set; }

        // Non-nullable properties with default initialization
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";

        // Other properties as needed
    }
}
