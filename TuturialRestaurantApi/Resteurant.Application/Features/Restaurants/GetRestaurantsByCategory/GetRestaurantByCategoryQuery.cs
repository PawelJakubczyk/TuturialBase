using MediatR;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;
public sealed record GetRestaurantByCategoryQuery(string Cateogry) : IRequest<List<Restaurant>>;
