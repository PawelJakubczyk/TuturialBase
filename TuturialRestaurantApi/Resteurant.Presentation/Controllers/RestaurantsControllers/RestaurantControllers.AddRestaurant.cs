using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> AddRestaurant([FromBody] Restaurant restaurant)
    {
        await _restaurantService.AddRestaurant(restaurant);
        return CreatedAtAction(nameof(GetRestaurantById), new { id = restaurant.Id }, restaurant);
    }
}