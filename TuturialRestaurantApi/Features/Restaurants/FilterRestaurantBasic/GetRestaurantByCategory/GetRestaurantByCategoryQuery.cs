using MediatR;
using TutorialRestaurantBase.Entities;

public sealed record GetRestaurantByCategoryQuery(string Cateogry) : IRequest<Restaurant>;
