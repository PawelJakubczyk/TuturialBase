using MongoDB.Driver;
using TuturialWebApi.Entieties;

namespace TuturialWebApi.Data;

public interface IMovieContext
{
    IMongoCollection<Movie> Movies { get; }
}
