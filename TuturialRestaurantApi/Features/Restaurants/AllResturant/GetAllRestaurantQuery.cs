using MediatR;
using TutorialRestaurantBase.Entities;

public sealed record GetAllRestaurantQuery(string Id) : IRequest<Restaurant>;
