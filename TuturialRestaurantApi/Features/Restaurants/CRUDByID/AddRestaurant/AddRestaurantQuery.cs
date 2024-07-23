using MediatR;
using TutorialRestaurantApi.Entities;

namespace TutorialRestaurantApi.Features.Restaurant;

public sealed record AddRestaurantQuery(string Id) : IRequest<string>;
