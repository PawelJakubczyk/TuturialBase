using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using TuturialRestaurantBase.Data;
using TutorialRestaurantBase.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using TutorialWebApi.Services;

namespace TuturialWebApi.Controllers;


public partial class RestaurantController : ControllerBase
{
    // Get all restaurants
    [HttpGet]
    public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
    {
        return await _restaurantService.GetAllRestaurants();
    }
}
