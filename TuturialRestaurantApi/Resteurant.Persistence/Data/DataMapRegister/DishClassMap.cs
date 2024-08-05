using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Persistence.DataMapRegister;

// Registering a class for the Entities/Dish class and mapping registration for Address and Dish
public static class DishClassMap
{
    public static void Register()
    {
        BsonClassMap.RegisterClassMap<Dish>(classMap =>
        {
            classMap.MapMember(d => d.DishID)
                .SetElementName("DishID")
                .SetOrder(1);

            classMap.MapMember(d => d.DishName)
                .SetElementName("DishName")
                .SetOrder(2);

            classMap.MapMember(d => d.DishPrice)
                .SetElementName("DishPrice")
                .SetSerializer(new DecimalSerializer(BsonType.Decimal128))
                .SetOrder(3);

            classMap.MapMember(d => d.DishDescription)
                .SetElementName("DishDescription")
                .SetOrder(4);
        });
    }
}

