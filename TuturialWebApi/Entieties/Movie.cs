using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace TuturialWebApi.Entieties;

public class Movie
{
    [BsonId]
    [BsonElement("_id")]
    public string? Id { get; set; }

    [BsonElement("coming_soon")]
    public bool? ComingSoon { get; set; }

    [BsonElement("title")]
    public string? Title { get; set; }

    [BsonElement("year")]
    public string? Year { get; set; }

    [BsonElement("rated")]
    public string? Rated { get; set; }

    [BsonElement("released")]
    public string? Released { get; set; }

    [BsonElement("runtime")]
    public string? Runtime { get; set; }

    [BsonElement("genre")]
    public string? Genre { get; set; }

    [BsonElement("director")]
    public string? Director { get; set; }

    [BsonElement("writer")]
    public string? Writer { get; set; }

    [BsonElement("actors")]
    public string? Actors { get; set; }

    [BsonElement("plot")]
    public string? Plot { get; set; }

    [BsonElement("language")]
    public string? Language { get; set; }

    [BsonElement("country")]
    public string? Country { get; set; }

    [BsonElement("awards")]
    public string? Awards { get; set; }

    [BsonElement("poster")]
    public string? Poster { get; set; }

    [BsonElement("metascore")]
    public string? Metascore { get; set; }

    [BsonElement("imdb_rating")]
    public string? ImdbRating { get; set; }

    [BsonElement("imdb_votes")]
    public string? ImdbVotes { get; set; }

    [BsonElement("imdb_id")]
    public string? ImdbID { get; set; }

    [BsonElement("type")]
    public string? Type { get; set; }

    [BsonElement("response")]
    public string? Response { get; set; }

    [BsonElement("images")]
    public List<string>? Images { get; set; }
}
