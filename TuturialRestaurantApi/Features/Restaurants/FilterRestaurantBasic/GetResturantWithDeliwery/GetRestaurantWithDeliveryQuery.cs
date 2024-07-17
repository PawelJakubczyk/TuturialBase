using MediatR;
using TutorialRestaurantBase.Entities;

public sealed record GetRestaurantWithDeliveryQuery(bool Delivery) : IRequest<Restaurant>;
