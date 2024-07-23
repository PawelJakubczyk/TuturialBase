using MediatR;
using TutorialRestaurantApi.Entities;

public sealed record GetAllRestaurantQuery(string Id) : IRequest<Restaurant>;
