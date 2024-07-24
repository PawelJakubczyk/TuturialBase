using MediatR;
using TutorialRestaurantApi.Entities;

namespace TutorialRestaurantApi.Features.Restaurants;

public sealed record GetAllRestaurantQuery(string Id) : IRequest<Restaurant>;
