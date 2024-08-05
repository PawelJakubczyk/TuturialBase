using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Application.Features.Restaurants;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantControllerMediator : ControllerBase
{
    [HttpGet("mediator/{id}")]
    public async Task<ActionResult<Restaurant>> GetRestaurantByIdUsingMediator(string id)
    {
        var request = new GetRestaurantByIdQuery(id);

        var restaurant = await _sender.Send(request);

        if (restaurant is null)
        {
            return NotFound();
        }

        return restaurant;
    }
}