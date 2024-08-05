using MediatR;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;
public sealed record GetRestaurantWithDeliveryQuery(bool Delivery) : IRequest<List<Restaurant>>;
