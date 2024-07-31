using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantController : ControllerBase
{
    [HttpGet("delivery")]
    public async Task<IEnumerable<Restaurant>> GetRestaurantsWithDelivery()
    {
        return await _restaurantService.GetRestaurantsWithDelivery();
    }
}