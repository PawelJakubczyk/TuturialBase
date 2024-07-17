using MediatR;
using MongoDB.Driver;
using System.Threading;
using TutorialRestaurantBase.Entities;
using TuturialRestaurantApi.Features.Restaurants.CRUDByID.GetById;
using TuturialRestaurantBase.Data;

namespace TuturialRestaurantApi.Features.Restaurants.CRUDByID.AddRestaurant;

public sealed class AddRestaurantQueryHandler : IRequestHandler<AddRestaurantQuery, string>
{
    private readonly IRestaurantContext _restaurantContext;
    private readonly Restaurant _newRestaurant;

    public AddRestaurantQueryHandler(IRestaurantContext restaurantContext, Restaurant newRestaurant)
    {
        _restaurantContext = restaurantContext;
        _newRestaurant = newRestaurant;
    }

    public async Task<string> Handle(AddRestaurantQuery query, CancellationToken cancellationToken)
    {
        await _restaurantContext.Restaurants.InsertOneAsync(_newRestaurant);
        return query.ToString();
    }
}