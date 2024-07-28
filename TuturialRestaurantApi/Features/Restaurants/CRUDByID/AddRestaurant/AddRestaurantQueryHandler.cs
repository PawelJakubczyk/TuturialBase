using MediatR;
using TutorialRestaurantApi.Entities;
using TutorialRestaurantApi.Features.Restaurants;
using TuturialRestaurantApi.Data;

namespace TuturialRestaurantApi.Features.Restaurants.CRUDByID.AddRestaurant;

public sealed class AddRestaurantQueryHandler : IRequestHandler<AddRestaurantQuery, string>
{
    private readonly IRestaurantContext _restaurantContext;

    public AddRestaurantQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<string> Handle(AddRestaurantQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
        //await _restaurantContext.Restaurants.InsertOneAsync(_newRestaurant);
        //return query.ToString();
    }
}