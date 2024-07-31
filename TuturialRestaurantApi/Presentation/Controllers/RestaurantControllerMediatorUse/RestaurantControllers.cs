using MediatR;
using Microsoft.AspNetCore.Mvc;
using TutorialWebApi.Services;
using TuturialRestaurantApi.Application.Features.Restaurants;
using TuturialRestaurantApi.Domain.Entities;

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
