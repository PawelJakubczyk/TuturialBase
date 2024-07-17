using MediatR;
using MongoDB.Driver;
using TutorialRestaurantBase.Entities;
using TuturialRestaurantBase.Data;

public sealed class GetRestaurantByCityQueryHandler : IRequestHandler<GetRestaurantByCityQuery, Restaurant>
{
    private readonly IRestaurantContext _restaurantContext;

    public GetRestaurantByCityQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<Restaurant> Handle(GetRestaurantByCityQuery query, CancellationToken cancellationToken)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, query.City);
        return await _restaurantContext.Restaurants.Find(filter).FirstOrDefaultAsync(cancellationToken);
    }
}
