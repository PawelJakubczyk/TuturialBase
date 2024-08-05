using MediatR;
using MongoDB.Driver;
using TuturialRestaurantApi.Persistence.DataContext;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;
public sealed class GetRestaurantByCategoryQueryHandler : IRequestHandler<GetRestaurantByCategoryQuery, List<Restaurant>>
{
    private readonly IRestaurantContext _restaurantContext;

    public GetRestaurantByCategoryQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<List<Restaurant>> Handle(GetRestaurantByCategoryQuery query, CancellationToken cancellationToken)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Category, query.Cateogry);
        return await _restaurantContext.Restaurants.Find(filter).ToListAsync(cancellationToken);
    }
}