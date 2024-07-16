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

    // Get a restaurant by ID
    [HttpGet("{id}")]
    public async Task<ActionResult<Restaurant>> GetRestaurantById(string id)
    {
        var restaurant = await _restaurantService.GetRestaurantById(id);

        if (restaurant == null)
        {
            return NotFound();
        }

        return restaurant;
    }

    // Update an existing restaurant
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateRestaurant(string id, [FromBody] Restaurant restaurant)
    {
        bool isUpdated = await _restaurantService.UpdateRestaurant(id, restaurant);

        if (!isUpdated)
        {
            return NotFound();
        }

        return NoContent();
    }

    // Delete a restaurant
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRestaurant(string id)
    {
        bool isDeleted = await _restaurantService.DeleteRestaurant(id);

        if (!isDeleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}
