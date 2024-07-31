using MediatR;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;

public sealed record DeleteRestaurantCommand(string Id) : IRequest<Restaurant>;











