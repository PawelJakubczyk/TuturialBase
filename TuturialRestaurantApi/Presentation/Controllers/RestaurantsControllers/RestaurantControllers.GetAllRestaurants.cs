using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantController : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
    {
        return await _restaurantService.GetAllRestaurants();
    }
}

