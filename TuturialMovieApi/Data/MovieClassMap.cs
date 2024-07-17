using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using System.Reflection;
using TuturialWebApi.Entieties;

namespace TuturialWebApi.Data;

public static class MovieClassMap
{
    public static void Register()
    {
        BsonClassMap.RegisterClassMap<Movie>(classMap =>
        {
            classMap.MapIdMember(m => m.Id)
                .SetElementName("_id")
                .SetIdGenerator(StringObjectIdGenerator.Instance)
                .SetSerializer(new StringSerializer(BsonType.ObjectId))
                .SetOrder(1);

            classMap.MapMember(m => m.Title)
                .SetElementName(nameof(Movie.Title))
                .SetOrder(2);

            //classMap.MapMember(m => m.Year)
            //    .SetElementName(nameof(Movie.Year))
            //    .SetSerializer(new StringSerializer(BsonType.String)) // Dodane mapowanie do string
            //    .SetOrder(3);

            classMap.MapMember(m => m.Rated)
                .SetElementName(nameof(Movie.Rated))
                .SetOrder(3);
        });
    }
}