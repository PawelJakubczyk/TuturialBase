using MediatR;
using TutorialRestaurantApi.Entities;

public sealed record GetRestaurantByCityQuery(string City) : IRequest<Restaurant>;
