using MediatR;
using TuturialRestaurantApi.Domain.Entities;
using TuturialRestaurantApi.Persistence.DataContext;

namespace TuturialRestaurantApi.Application.Features.Restaurants;

public sealed class AddRestaurantCommandHandler : IRequestHandler<AddRestaurantCommand, Restaurant>
{
    private readonly IRestaurantContext _restaurantContext;

    public AddRestaurantCommandHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<Restaurant> Handle(AddRestaurantCommand command, CancellationToken cancellationToken)
    {
        await _restaurantContext.Restaurants.InsertOneAsync(command.Restaurant, null, cancellationToken);
        return command.Restaurant;
    }
}