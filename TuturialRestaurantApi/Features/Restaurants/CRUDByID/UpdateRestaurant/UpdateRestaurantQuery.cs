using MediatR;
using TutorialRestaurantBase.Entities;

public sealed record UpdateRestaurantQuery(string Id) : IRequest<string>;
