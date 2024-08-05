using MediatR;
using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Application.Features.Restaurants;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;
public partial class RestaurantControllerMediator : ControllerBase
{
    [HttpGet("mediator/delivery")]
    public async Task<ActionResult<List<Restaurant>>> GetRestaurantsWithDeliweryUsingMediator(string city)
    {
        var request = new GetRestaurantWithDeliveryQuery(true);

        var restaurant = await _sender.Send(request);

        if (restaurant is null)
        {
            return NotFound();
        }

        return restaurant;
    }
}