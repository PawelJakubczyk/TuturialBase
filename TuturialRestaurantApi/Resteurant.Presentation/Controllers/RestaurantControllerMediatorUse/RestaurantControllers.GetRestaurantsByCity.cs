using MediatR;
using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Application.Features.Restaurants;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantControllerMediator : ControllerBase
{
    [HttpGet("mediator/city/{city}")]
    public async Task<ActionResult<List<Restaurant>>> GetRestaurantsByCityUsingMediator(string city)
    {
        var request = new GetRestaurantByCityQuery(city);

        var restaurant = await _sender.Send(request);

        if (restaurant is null)
        {
            return NotFound();
        }

        return restaurant;
    }
}