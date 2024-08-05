using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Application.Features.Restaurants;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantControllerMediator : ControllerBase
{
    [HttpGet("mediator/category/{category}")]
    public async Task<ActionResult<List<Restaurant>>> GetRestaurantsByCategoryUsingMediator(string category)
    {
        var request = new GetRestaurantByCategoryQuery(category);

        var restaurant = await _sender.Send(request);

        if (restaurant is null)
        {
            return NotFound();
        }

        return restaurant;
    }
}