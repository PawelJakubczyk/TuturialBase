using MediatR;
using MongoDB.Driver;
using TutorialRestaurantBase.Entities;
using TuturialRestaurantBase.Data;

namespace TuturialRestaurantApi.Features.Restaurants.CRUDByID.DelateRestaurant;

public sealed class DelateRestaurantQueryHandler : IRequestHandler<DelateRestaurantQuery, string>
{
    private readonly IRestaurantContext _restaurantContext;

    public DelateRestaurantQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<string> Handle(DelateRestaurantQuery query, CancellationToken cancellationToken)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, query.Id);
        var result = await _restaurantContext.Restaurants.DeleteOneAsync(filter);

        return query.Id;
    }
}
