using MediatR;
using TutorialRestaurantApi.Entities;

namespace TutorialRestaurantApi.Features.Restaurants;

public sealed record AddRestaurantQuery(string Id) : IRequest<string>;
