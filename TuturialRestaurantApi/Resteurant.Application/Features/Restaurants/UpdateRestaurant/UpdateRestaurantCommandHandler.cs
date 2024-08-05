using MediatR;
using MongoDB.Driver;
using TuturialRestaurantApi.Persistence.DataContext;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;

public sealed class UpdateRestaurantCommandHandler : IRequestHandler<UpdateRestaurantCommand, string>
{
    private readonly IRestaurantContext _restaurantContext;

    public UpdateRestaurantCommandHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<string> Handle(UpdateRestaurantCommand command, CancellationToken cancellationToken)
    {
        var queryFilter = Builders<Restaurant>.Filter.Eq(r => r.Id, command.Id);
        var resturantToUpdate = await _restaurantContext.Restaurants.Find(queryFilter).FirstOrDefaultAsync(cancellationToken);

        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, command.Id);
        var result = await _restaurantContext.Restaurants.ReplaceOneAsync(filter, resturantToUpdate);

        return command.Id;
    }
}