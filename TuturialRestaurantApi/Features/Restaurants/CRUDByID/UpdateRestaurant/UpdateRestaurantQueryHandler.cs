using MediatR;
using MongoDB.Driver;
using TutorialRestaurantApi.Entities;
using TuturialRestaurantApi.Data;

public sealed class UpdateRestaurantQueryHandler : IRequestHandler<UpdateRestaurantQuery, string>
{
    private readonly IRestaurantContext _restaurantContext;

    public UpdateRestaurantQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<string> Handle(UpdateRestaurantQuery query, CancellationToken cancellationToken)
    {
        var queryFilter = Builders<Restaurant>.Filter.Eq(r => r.Id, query.Id);
        var resturantToUpdate = await _restaurantContext.Restaurants.Find(queryFilter).FirstOrDefaultAsync(cancellationToken);

        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, query.Id);
        var result = await _restaurantContext.Restaurants.ReplaceOneAsync(filter, resturantToUpdate);

        return query.Id;
    }
}