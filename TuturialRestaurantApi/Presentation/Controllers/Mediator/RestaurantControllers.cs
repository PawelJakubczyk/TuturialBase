using MediatR;
using Microsoft.AspNetCore.Mvc;
using TutorialWebApi.Services;

namespace TuturialWebApi.Controllers.Mediator;

[Route("api/[controller]")]
[ApiController]
public partial class RestaurantMediatorController : ControllerBase
{
    private readonly RestaurantService _restaurantService;
    private readonly ISender _sender;

    public RestaurantMediatorController(RestaurantService restaurantService, ISender sender)
    {
        _restaurantService = restaurantService;
        _sender = sender;
    }
}
