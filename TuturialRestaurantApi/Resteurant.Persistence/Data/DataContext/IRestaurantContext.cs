using MongoDB.Driver;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Persistence.DataContext;

public interface IRestaurantContext
{
    IMongoCollection<Restaurant> Restaurants { get; }
}