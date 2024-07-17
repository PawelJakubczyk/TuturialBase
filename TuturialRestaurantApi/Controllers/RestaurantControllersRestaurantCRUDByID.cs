using MediatR;
using Microsoft.AspNetCore.Mvc;
using TutorialRestaurantBase.Entities;
using TuturialRestaurantApi.Features.Restaurants.CRUDByID.GetById;
using TuturialRestaurantApi.Features.Restaurants.GetById;

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

    // Get a restaurant by ID using mediator
    [HttpGet("mediator/{id}")]
    public async Task<ActionResult<Restaurant>> GetRestaurantByIdUsingMediator(string id)
    {
        var request = new GetRestaurantByIdQuery(id);

        var restaurant = await _sender.Send(request);

        if (restaurant is null)
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

    // Add a new restaurant
    [HttpPost]
    public async Task<IActionResult> AddRestaurant([FromBody] Restaurant restaurant)
    {
        await _restaurantService.AddRestaurant(restaurant);
        return CreatedAtAction(nameof(GetRestaurantById), new { id = restaurant.Id }, restaurant);
    }

    // Add a new restaurant
    [HttpPost("mediator/")]
    public async Task<IActionResult> AddRestaurantMediator([FromBody] Restaurant restaurant)
    {
        await _restaurantService.AddRestaurant(restaurant);
        return CreatedAtAction(nameof(GetRestaurantById), new { id = restaurant.Id }, restaurant);
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


//[HttpGet("mediator/{id}")]
//public async Task<ActionResult<Restaurant>> GetRestaurantByIdUsingMediator(string id)
//{
//    var request = new GetRestaurantByIdQuery(id);

//    var restaurant = await _sender.Send(request);

//    if (restaurant is null)
//    {
//        return NotFound();
//    }

//    return restaurant;
//}