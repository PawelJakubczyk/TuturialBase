using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using TuturialRestaurantApi.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;
using TutorialWebApi.Services;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialWebApi.Controllers.Mediator;


public partial class RestaurantMediatorController : ControllerBase
{
    // Get all restaurants
    [HttpGet]
    public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
    {
        return await _restaurantService.GetAllRestaurants();
    }
}
