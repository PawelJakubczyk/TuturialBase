using MongoDB.Driver;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Data.DataContext
{
    public interface IRestaurantContext
    {
        IMongoCollection<Restaurant> Restaurants { get; }
    }
}