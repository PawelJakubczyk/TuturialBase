using MediatR;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;

public sealed record GetRestaurantByIdQuery(string Id) : IRequest<Restaurant>;
