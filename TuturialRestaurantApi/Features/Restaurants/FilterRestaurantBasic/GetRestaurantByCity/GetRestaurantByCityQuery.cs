using MediatR;
using TutorialRestaurantBase.Entities;

public sealed record GetRestaurantByCityQuery(string City) : IRequest<Restaurant>;
