using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantController : ControllerBase
{
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateRestaurant(string id, [FromBody] Restaurant restaurant)
    {
        bool isUpdated = await _restaurantService.UpdateRestaurant(id, restaurant);

        if (!isUpdated)
        {
            return NotFound();
        }

        return NoContent();
    }
}