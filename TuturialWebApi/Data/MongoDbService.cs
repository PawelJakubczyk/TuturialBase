using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Misc;
using TuturialWebApi.Entieties;

namespace TuturialWebApi.Data;

public class MongoDbService<TModel>
{
    private readonly IConfiguration _configuration;
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<TModel> _collection;

    public MongoDbService(IConfiguration configuration)
    {
        _configuration = configuration;


        var connectionString = _configuration.GetConnectionString("DBConection");
        //var mongoUrl = MongoUrl.Create(connectionString);
        var mongoClient = new MongoClient(connectionString);

        var databaseName = _configuration.GetConnectionString("DocumentName");
        _database = mongoClient.GetDatabase(databaseName);
        
        var collectionName = _configuration.GetConnectionString("CollectionName");
        _collection = _database.GetCollection<TModel>(collectionName);


        FilterDefinition<Movie> filter = Builders<Movie>.Filter.Eq(p => p.Title, "I am Legend");
        var xx = _collection<IMongoCollection<Movie>>
                    .Find(filter)
                    .FirstOrDefault();

    }

    public IMongoDatabase GetDatabase => _database;

    public IMongoCollection<TModel> GetCollection => _collection;
}


//public class MongoDbService
//{
//    private readonly IConfiguration _configuration;
//    private readonly IMongoDatabase _database;

//    public MongoDbService(IConfiguration configuration)
//    {
//        _configuration = configuration;

//        var connectionString = _configuration.GetConnectionString("DBConection");
//        var mongoUrl = MongoUrl.Create(connectionString);
//        var mongoClient = new MongoClient(mongoUrl);

//        var databaseName = _configuration.GetConnectionString("DocumentName");
//        _database = mongoClient.GetDatabase(databaseName);


//    }

//    public IMongoDatabase Database => _database;

//    public IMongoCollection<T> GetCollection<T>(string name)
//    {
//        return _database.GetCollection<T>(name);
//    }
//}
