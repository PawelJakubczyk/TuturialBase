using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using TutorialRestaurantBase.Entities;

namespace TuturialRestaurantBase.Data;

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

