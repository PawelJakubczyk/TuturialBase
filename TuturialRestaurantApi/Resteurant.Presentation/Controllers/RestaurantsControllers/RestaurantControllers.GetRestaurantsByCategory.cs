using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantController : ControllerBase
{
    [HttpGet("category/{category}")]
    public async Task<IEnumerable<Restaurant>> GetRestaurantsByCategory(string category)
    {
        return await _restaurantService.GetRestaurantsByCategory(category);
    }
}