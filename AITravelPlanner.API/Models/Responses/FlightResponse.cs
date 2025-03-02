namespace AITravelPlanner.API.Models.Responses
{
    public class FlightResponse
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DepartureDate { get; set; }
        public decimal Price { get; set; }
    }
}
