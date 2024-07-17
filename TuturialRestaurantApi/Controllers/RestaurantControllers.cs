using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using TuturialRestaurantBase.Data;
using TutorialRestaurantBase.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using TutorialWebApi.Services;

namespace TuturialWebApi.Controllers;




[Route("api/[controller]")]
[ApiController]
public partial class RestaurantController : ControllerBase
{
    private readonly RestaurantService _restaurantService;

    public RestaurantController(RestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }

    // Add a new restaurant
    [HttpPost]
    public async Task<IActionResult> AddRestaurant([FromBody] Restaurant restaurant)
    {
        await _restaurantService.AddRestaurant(restaurant);
        return CreatedAtAction(nameof(GetRestaurantById), new { id = restaurant.Id }, restaurant);
    }

}
