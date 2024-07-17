using MediatR;
using MongoDB.Driver;
using TutorialRestaurantBase.Entities;
using TuturialRestaurantBase.Data;

namespace TuturialRestaurantApi.Features.Restaurants.CRUDByID.GetById;

public sealed class GetRestaurantByIdQueryHandler : IRequestHandler<GetRestaurantByIdQuery, Restaurant>
{
    private readonly IRestaurantContext _restaurantContext;

    public GetRestaurantByIdQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<Restaurant> Handle(GetRestaurantByIdQuery query, CancellationToken cancellationToken)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, query.Id);
        return await _restaurantContext.Restaurants.Find(filter).FirstOrDefaultAsync(cancellationToken);
    }
}
