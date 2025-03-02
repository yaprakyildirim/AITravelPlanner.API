namespace AITravelPlanner.API.Models.Requests
{
    public class RegisterRequest
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
