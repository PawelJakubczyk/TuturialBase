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
                .SetOrder(1)
                .SetIdGenerator(StringObjectIdGenerator.Instance)
                .SetSerializer(new StringSerializer(BsonType.ObjectId));

            classMap.MapMember(m => m.Title)
                .SetElementName(nameof(Movie.Title))
                .SetOrder(2);

            classMap.MapMember(m => m.Year)
                .SetElementName(nameof(Movie.Year))
                .SetOrder(3);

            classMap.MapMember(m => m.Rated)
                .SetElementName(nameof(Movie.Rated))
                .SetOrder(4);
        });
    }
}