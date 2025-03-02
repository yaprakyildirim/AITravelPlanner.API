namespace AITravelPlanner.Domain.Entities
{
    public class Flight : BaseEntity
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DepartureDate { get; set; }
        public decimal Price { get; set; }
    }
}
