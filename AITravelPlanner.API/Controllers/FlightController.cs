using AITravelPlanner.API.Models.Responses;
using AITravelPlanner.Services.Services.Abstract;
using AITravelPlanner.Services.Services.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AITravelPlanner.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService _flightService;

        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchFlights([FromQuery] string from, [FromQuery] string to)
        {
            var flights = await _flightService.SearchFlightsAsync(from, to);
            var response = flights.Select(f => new FlightResponse
            {
                Id = f.Id,
                From = f.From,
                To = f.To,
                DepartureDate = f.DepartureDate,
                Price = f.Price
            }).ToList();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFlight(int id)
        {
            var flight = await _flightService.GetFlightByIdAsync(id);
            if (flight == null) return NotFound();

            return Ok(new FlightResponse
            {
                Id = flight.Id,
                From = flight.From,
                To = flight.To,
                DepartureDate = flight.DepartureDate,
                Price = flight.Price
            });
        }
    }
}
