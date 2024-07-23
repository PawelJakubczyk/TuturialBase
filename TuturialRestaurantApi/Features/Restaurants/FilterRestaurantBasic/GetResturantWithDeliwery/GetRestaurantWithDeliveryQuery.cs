using MediatR;
using TutorialRestaurantApi.Entities;

public sealed record GetRestaurantWithDeliveryQuery(bool Delivery) : IRequest<Restaurant>;
