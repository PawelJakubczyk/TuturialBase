using MediatR;
using MongoDB.Driver;
using TuturialRestaurantApi.Persistence.DataContext;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;


public sealed class DeleteRestaurantCommandHandler : IRequestHandler<DeleteRestaurantCommand, Restaurant>
{
    private readonly IRestaurantContext _restaurantContext;

    public DeleteRestaurantCommandHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<Restaurant> Handle(DeleteRestaurantCommand command, CancellationToken cancellationToken)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, command.Id);
        var restaurant = await _restaurantContext.Restaurants.Find(filter).FirstOrDefaultAsync(cancellationToken);

        if (restaurant == null)
        {
            return null;
        }

        var result = await _restaurantContext.Restaurants.DeleteOneAsync(filter, cancellationToken);

        return restaurant;
    }
}