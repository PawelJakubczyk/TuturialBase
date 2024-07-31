using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Application.Features.Restaurants;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantControllerMediator : ControllerBase
{
    [HttpPost("mediator/")]
    public async Task<ActionResult> AddRestaurantUsingMediator([FromBody] Restaurant restaurantToAdd)
    {
        if (restaurantToAdd == null)
        {
            return BadRequest("Restaurant cannot be null");
        }

        var request = new AddRestaurantCommand(restaurantToAdd);
        var result = await _sender.Send(request);

        return CreatedAtAction(nameof(AddRestaurantUsingMediator), new { id = result.Id }, result);
    }
}