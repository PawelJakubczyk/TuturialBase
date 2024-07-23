using MediatR;
using MongoDB.Driver;
using TutorialRestaurantApi.Entities;
using TuturialRestaurantApi.Data;

public sealed class GetRestaurantWithDeliveryQueryHandler : IRequestHandler<GetRestaurantWithDeliveryQuery, Restaurant>
{
    private readonly IRestaurantContext _restaurantContext;

    public GetRestaurantWithDeliveryQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<Restaurant> Handle(GetRestaurantWithDeliveryQuery query, CancellationToken cancellationToken)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.HasDelivery, true);
        return await _restaurantContext.Restaurants.Find(filter).FirstOrDefaultAsync(cancellationToken);
    }
}
