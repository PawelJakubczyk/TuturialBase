using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TuturialWebApi.Entieties;

public sealed class Movie
(
    string id,
    string title,
    //string year,
    string rated
)
{
    public string Id { get; set; } = id;
    public string Title { get; set; } = title;
    //public string Year { get; set; } = year;
    public string? Rated { get; set; } = rated;
}