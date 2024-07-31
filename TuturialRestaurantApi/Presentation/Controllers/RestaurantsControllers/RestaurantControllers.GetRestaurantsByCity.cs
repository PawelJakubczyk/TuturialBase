using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantController : ControllerBase
{
    [HttpGet("city/{city}")]
    public async Task<IEnumerable<Restaurant>> GetRestaurantsByCity(string city)
    {
        return await _restaurantService.GetRestaurantsByCity(city);
    }
}