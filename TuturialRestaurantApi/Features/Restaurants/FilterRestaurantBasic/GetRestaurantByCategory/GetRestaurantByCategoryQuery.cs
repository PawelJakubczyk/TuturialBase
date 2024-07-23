using MediatR;
using TutorialRestaurantApi.Entities;

public sealed record GetRestaurantByCategoryQuery(string Cateogry) : IRequest<Restaurant>;
