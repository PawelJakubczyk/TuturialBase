using MediatR;
using TutorialRestaurantApi.Entities;

namespace TuturialRestaurantApi.Features.Restaurants.CRUDByID.GetById;

public sealed record GetRestaurantByIdQuery(string Id) : IRequest<Restaurant>;
