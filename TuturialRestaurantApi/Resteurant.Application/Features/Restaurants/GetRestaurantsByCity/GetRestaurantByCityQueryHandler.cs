using MediatR;
using MongoDB.Driver;
using TuturialRestaurantApi.Persistence.DataContext;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;
public sealed class GetRestaurantByCityQueryHandler : IRequestHandler<GetRestaurantByCityQuery, List<Restaurant>>
{
    private readonly IRestaurantContext _restaurantContext;

    public GetRestaurantByCityQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<List<Restaurant>> Handle(GetRestaurantByCityQuery query, CancellationToken cancellationToken)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, query.City);
        return await _restaurantContext.Restaurants.Find(filter).ToListAsync(cancellationToken);
    }
}
