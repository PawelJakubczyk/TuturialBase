using MediatR;
using TutorialRestaurantApi.Entities;

public sealed record UpdateRestaurantQuery(string Id) : IRequest<string>;
