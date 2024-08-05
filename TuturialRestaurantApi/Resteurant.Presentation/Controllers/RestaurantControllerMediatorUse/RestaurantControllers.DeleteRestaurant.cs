using Microsoft.AspNetCore.Mvc;
using TuturialRestaurantApi.Application.Features.Restaurants;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantController : ControllerBase
{
    [HttpDelete("mediator/{id}")]
    public async Task<IActionResult> DeleteRestaurant(string id)
    {
        var request = new DeleteRestaurantCommand(id);

        var restaurant = _sender.Send(request);

        if (restaurant is null)
        {
            return NotFound();
        }

        return NoContent();
    }
}