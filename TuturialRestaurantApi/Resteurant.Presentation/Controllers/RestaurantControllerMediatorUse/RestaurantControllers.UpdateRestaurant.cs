using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Application.Features.Restaurants;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantController : ControllerBase
{
    [HttpPut("mediator/{id}")]
    public async Task<IActionResult> UpdateRestaurant(string id, [FromBody] Restaurant restaurant)
    {
        var request = new UpdateRestaurantCommand(id, restaurant);

        bool isUpdated = await _restaurantService.UpdateRestaurant(id, restaurant);

        if (!isUpdated)
        {
            return NotFound();
        }

        return NoContent();
    }
}