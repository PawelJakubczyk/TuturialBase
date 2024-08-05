using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantController : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<ActionResult<Restaurant>> GetRestaurantById(string id)
    {
        var restaurant = await _restaurantService.GetRestaurantById(id);

        if (restaurant == null)
        {
            return NotFound();
        }

        return restaurant;
    }
}