using MediatR;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;
public sealed record GetRestaurantByCityQuery(string City) : IRequest<List<Restaurant>>;
