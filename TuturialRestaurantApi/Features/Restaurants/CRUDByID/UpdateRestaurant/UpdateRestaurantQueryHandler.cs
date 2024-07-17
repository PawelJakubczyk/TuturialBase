using MediatR;
using MongoDB.Driver;
using TutorialRestaurantBase.Entities;
using TuturialRestaurantBase.Data;

public sealed class UpdateRestaurantQueryHandler : IRequestHandler<UpdateRestaurantQuery, string>
{

    private readonly IRestaurantContext _restaurantContext;
    private readonly Restaurant _updateRestaurant;

    public UpdateRestaurantQueryHandler(IRestaurantContext restaurantContext, Restaurant updateRestaurant)
    {
        _restaurantContext = restaurantContext;
        _updateRestaurant = updateRestaurant;
    }

    public async Task<string> Handle(UpdateRestaurantQuery query, CancellationToken cancellationToken)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, query.Id);
        var result = await _restaurantContext.Restaurants.ReplaceOneAsync(filter, _updateRestaurant);

        return query.Id;
    }
}