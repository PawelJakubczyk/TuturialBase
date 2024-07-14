using MongoDB.Driver;
using TuturialWebApi.Entieties;

namespace TuturialWebApi.Data;

public class MovieContext : IMovieContext
{
    static MovieContext()
    {
        MovieClassMap.Register();
    }

    public MovieContext(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DBConection");
        var databaseName = configuration.GetConnectionString("DocumentName");
        var collectionName = configuration.GetConnectionString("CollectionName");

        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        Movies = database.GetCollection<Movie>(collectionName);
    }

    public IMongoCollection<Movie> Movies { get; }
}