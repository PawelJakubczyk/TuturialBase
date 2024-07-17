using MediatR;
using TutorialRestaurantBase.Entities;

public sealed record AddRestaurantQuery(string Id) : IRequest<string>;
