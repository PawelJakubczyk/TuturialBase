using MediatR;
using Microsoft.AspNetCore.Mvc;
using TutorialWebApi.Services;

namespace TuturialRestaurantApi.Presentation.Controllers.RestaurantsControlers;

[Route("api/mediator/[controller]")]
[ApiController]
public partial class RestaurantControllerMediator : ControllerBase
{
    private readonly RestaurantService _restaurantService;
    private readonly ISender _sender;

    public RestaurantControllerMediator(RestaurantService restaurantService, ISender sender)
    {
        _restaurantService = restaurantService;
        _sender = sender;
    }


}
