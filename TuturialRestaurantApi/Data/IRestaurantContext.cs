using MongoDB.Driver;
using TutorialRestaurantBase.Entities;

namespace TuturialRestaurantBase.Data
{
    public interface IRestaurantContext
    {
        IMongoCollection<Restaurant> Restaurants { get; }
    }
}