using MediatR;
using MongoDB.Driver;
using TuturialRestaurantApi.Data.DataContext;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;

public sealed class UpdateRestaurantCommandHandler : IRequestHandler<UpdateRestaurantCommand, string>
{
    private readonly IRestaurantContext _restaurantContext;

    public UpdateRestaurantCommandHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<string> Handle(UpdateRestaurantCommand query, CancellationToken cancellationToken)
    {
        var queryFilter = Builders<Restaurant>.Filter.Eq(r => r.Id, query.Id);
        var resturantToUpdate = await _restaurantContext.Restaurants.Find(queryFilter).FirstOrDefaultAsync(cancellationToken);

        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, query.Id);
        var result = await _restaurantContext.Restaurants.ReplaceOneAsync(filter, resturantToUpdate);

        return query.Id;
    }
}