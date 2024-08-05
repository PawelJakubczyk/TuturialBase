using MediatR;
using MongoDB.Driver;
using TuturialRestaurantApi.Persistence.DataContext;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;
public sealed class GetRestaurantWithDeliveryQueryHandler : IRequestHandler<GetRestaurantWithDeliveryQuery, List<Restaurant>>
{
    private readonly IRestaurantContext _restaurantContext;

    public GetRestaurantWithDeliveryQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<List<Restaurant>> Handle(GetRestaurantWithDeliveryQuery query, CancellationToken cancellationToken)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.HasDelivery, true);
        return await _restaurantContext.Restaurants.Find(filter).ToListAsync(cancellationToken);
    }
}
