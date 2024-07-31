using Microsoft.AspNetCore.Mvc;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

public partial class RestaurantController : ControllerBase
{
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