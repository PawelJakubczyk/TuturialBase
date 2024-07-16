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

    // Get restaurants by category
    [HttpGet("category/{category}")]
    public async Task<IEnumerable<Restaurant>> GetRestaurantsByCategory(string category)
    {
        return await _restaurantService.GetRestaurantsByCategory(category);
    }

    // Get restaurants by city
    [HttpGet("city/{city}")]
    public async Task<IEnumerable<Restaurant>> GetRestaurantsByCity(string city)
    {
        return await _restaurantService.GetRestaurantsByCity(city);
    }

    // Get restaurants that offer delivery
    [HttpGet("delivery")]
    public async Task<IEnumerable<Restaurant>> GetRestaurantsWithDelivery()
    {
        return await _restaurantService.GetRestaurantsWithDelivery();
    }
}
