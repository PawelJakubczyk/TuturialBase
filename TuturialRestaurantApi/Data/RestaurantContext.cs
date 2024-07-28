using MongoDB.Driver;
using TutorialRestaurantApi.Entities;
namespace TuturialRestaurantApi.Data;

public class RestaurantContext : IRestaurantContext
{
    static RestaurantContext()
    {
        RestaurantClassMap.Register();
    }

    public RestaurantContext(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DBConection");
        var databaseName = configuration.GetConnectionString("DocumentName");
        var collectionName = configuration.GetConnectionString("CollectionName");

        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        Restaurants = database.GetCollection<Restaurant>(collectionName);
    }

    public IMongoCollection<Restaurant> Restaurants { get; }
}


class MyProgram
{
    public void Execute()
    {
        var rogal = new Rogal();

        rogal.RequestPipeline([rogal.LogMe, rogal.PlayYkuza], rogal.ProcessRequest);
    }
}

