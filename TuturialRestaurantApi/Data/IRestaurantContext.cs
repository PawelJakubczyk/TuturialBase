using MongoDB.Driver;
using TutorialRestaurantApi.Entities;

namespace TuturialRestaurantApi.Data
{
    public interface IRestaurantContext
    {
        IMongoCollection<Restaurant> Restaurants { get; }
    }
}