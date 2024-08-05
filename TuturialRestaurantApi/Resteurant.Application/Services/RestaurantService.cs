using MongoDB.Driver;
using TuturialRestaurantApi.Domain.Entities;
using TuturialRestaurantApi.Persistence.DataContext;

namespace TutorialWebApi.Services;

public class RestaurantService
{
    private readonly IRestaurantContext _restaurantContext;

    public RestaurantService(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
    {
        return await _restaurantContext.Restaurants.Find(FilterDefinition<Restaurant>.Empty).ToListAsync();
    }

    public async Task<IEnumerable<Restaurant>> GetRestaurantsByCategory(string category)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Category, category);
        return await _restaurantContext.Restaurants.Find(filter).ToListAsync();
    }

    public async Task<IEnumerable<Restaurant>> GetRestaurantsByCity(string city)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Address.City, city);
        return await _restaurantContext.Restaurants.Find(filter).ToListAsync();
    }

    public async Task<IEnumerable<Restaurant>> GetRestaurantsWithDelivery()
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.HasDelivery, true);
        return await _restaurantContext.Restaurants.Find(filter).ToListAsync();
    }

    public async Task AddRestaurant(Restaurant restaurant)
    {
        await _restaurantContext.Restaurants.InsertOneAsync(restaurant);
    }

    public async Task<bool> UpdateRestaurant(string id, Restaurant restaurant)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, id);
        var result = await _restaurantContext.Restaurants.ReplaceOneAsync(filter, restaurant);

        return result.ModifiedCount > 0;
    }

    public async Task<bool> DeleteRestaurant(string id)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, id);
        var result = await _restaurantContext.Restaurants.DeleteOneAsync(filter);

        return result.DeletedCount > 0;
    }

    public async Task<Restaurant> GetRestaurantById(string id)
    {
        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, id);
        return await _restaurantContext.Restaurants.Find(filter).FirstOrDefaultAsync();
    }
}
