//using Microsoft.AspNetCore.Mvc;
//using TuturialRestaurantApi.Domain.Entities;
//using TuturialRestaurantApi.Application.Features.Restaurants;
//using TutorialWebApi.Services;

//namespace TuturialWebApi.Controllers;

//public partial class RestaurantController : ControllerBase
//{
//    // Get a restaurant by ID


//    // Get a restaurant by ID using mediator
//    [HttpGet("mediator/{id}")]
//    public async Task<ActionResult<Restaurant>> GetRestaurantByIdUsingMediator(string id)
//    {
//        var request = new GetRestaurantByIdQuery(id);

//        var restaurant = await _sender.Send(request);

//        if (restaurant is null)
//        {
//            return NotFound();
//        }

//        return restaurant;
//    }



//    // Add a new restaurant
//    [HttpPost("mediator/")]
//    public async Task<IActionResult> AddRestaurantMediator([FromBody] Restaurant restaurant)
//    {
//        await _restaurantService.AddRestaurant(restaurant);
//        return CreatedAtAction(nameof(GetRestaurantById), new { id = restaurant.Id }, restaurant);
//    }





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