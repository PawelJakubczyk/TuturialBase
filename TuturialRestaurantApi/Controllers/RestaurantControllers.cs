using MediatR;
using Microsoft.AspNetCore.Mvc;
using TutorialRestaurantBase.Entities;
using TutorialWebApi.Services;
using TuturialRestaurantApi.Features.Restaurants.CRUDByID.GetById;

namespace TuturialWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public partial class RestaurantController : ControllerBase
{
    private readonly RestaurantService _restaurantService;
    private readonly ISender _sender;

    public RestaurantController(RestaurantService restaurantService, ISender sender)
    {
        _restaurantService = restaurantService;
        _sender = sender;
    }
}
