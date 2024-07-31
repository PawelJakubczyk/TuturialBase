using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Domain.Entities;
using TuturialRestaurantApi.Application.Features.Restaurants;

namespace TuturialWebApi.Controllers.Mediator;

public partial class RestaurantMediatorController : ControllerBase
{


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

    // Update an existing restaurant using mediator
    //    [HttpPut("mediator/{id}")]
    //    public async Task<IActionResult> UpdateRestaurantUsingMediator(string id, [FromBody] Restaurant restaurant)
    //    {
    //        var request = new UpdateRestaurantCommand(id);

    //        var restaurant = await _sender.Send(request);

    //        bool isUpdated = await _restaurantService.UpdateRestaurant(id, restaurant);

    //        if (!isUpdated)
    //        {
    //            return NotFound();
    //        }

    //        return NoContent();
    //    }

    //    // Add a new restaurant
    //    [HttpPost]
    //    public async Task<IActionResult> AddRestaurant([FromBody] Restaurant restaurant)
    //    {
    //        await _restaurantService.AddRestaurant(restaurant);
    //        return CreatedAtAction(nameof(GetRestaurantById), new { id = restaurant.Id }, restaurant);
    //    }

    //    // Add a new restaurant
    //    [HttpPost("mediator/")]
    //    public async Task<IActionResult> AddRestaurantMediator([FromBody] Restaurant restaurant)
    //    {
    //        await _restaurantService.AddRestaurant(restaurant);
    //        return CreatedAtAction(nameof(GetRestaurantById), new { id = restaurant.Id }, restaurant);
    //    }

    //    // Delete a restaurant
    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> DeleteRestaurant(string id)
    //    {
    //        bool isDeleted = await _restaurantService.DeleteRestaurant(id);

    //        if (!isDeleted)
    //        {
    //            return NotFound();
    //        }

    //        return NoContent();
    //    }
    //}


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
}