using MediatR;
using TutorialRestaurantBase.Entities;

namespace TuturialRestaurantApi.Features.Restaurants.CRUDByID.DelateRestaurant;

public sealed record DelateRestaurantQuery(string Id) : IRequest<string>;











