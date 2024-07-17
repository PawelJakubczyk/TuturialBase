using MediatR;
using MongoDB.Driver;
using TutorialRestaurantBase.Entities;
using TuturialRestaurantBase.Data;

public sealed class GetRestaurantByCategoryQueryHandler : IRequestHandler<GetRestaurantByCategoryQuery, Restaurant>
{
    private readonly IRestaurantContext _restaurantContext;

    public GetRestaurantByCategoryQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<Restaurant> Handle(GetRestaurantByCategoryQuery query, CancellationToken cancellationToken)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Category, query.Cateogry);
        return await _restaurantContext.Restaurants.Find(filter).FirstOrDefaultAsync(cancellationToken);
    }
}
