using MediatR;
using MongoDB.Driver;
using TuturialRestaurantApi.Persistence.DataContext;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;

public sealed class GetAllRestaurantsQueryHandler : IRequestHandler<GetAllRestaurantsQuery, List<Restaurant>>
{
    private readonly IRestaurantContext _restaurantContext;

    public GetAllRestaurantsQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<List<Restaurant>> Handle(GetAllRestaurantsQuery query, CancellationToken cancellationToken)
    {
        return await _restaurantContext.Restaurants.Find(Builders<Restaurant>.Filter.Empty).ToListAsync(cancellationToken);
    }
}
