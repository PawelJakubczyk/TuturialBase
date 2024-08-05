using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Persistence.DataMapRegister;

// Registering a class for mapping for the EntitiesRestaurant class
public static class RestaurantClassMap
{
    public static void Register()
    {
        AddressClassMap.Register();
        DishClassMap.Register();

        BsonClassMap.RegisterClassMap<Restaurant>(classMap =>
        {
            classMap.MapMember(r => r.Id)
                .SetElementName("_id")
                .SetIdGenerator(StringObjectIdGenerator.Instance)
                .SetSerializer(new StringSerializer(BsonType.ObjectId))
                .SetOrder(1);

            classMap.MapMember(r => r.RestaurantName)
                .SetElementName(nameof(Restaurant.RestaurantName))
                .SetOrder(2);

            classMap.MapMember(r => r.Description)
                .SetElementName(nameof(Restaurant.Description))
                .SetOrder(3);

            classMap.MapMember(r => r.Category)
                .SetElementName(nameof(Restaurant.Category))
                .SetOrder(4);

            classMap.MapMember(r => r.HasDelivery)
                .SetElementName(nameof(Restaurant.HasDelivery))
                .SetOrder(5);

            classMap.MapMember(r => r.ContactEmail)
                .SetElementName(nameof(Restaurant.ContactEmail))
                .SetOrder(6);

            classMap.MapMember(r => r.ContactNumber)
                .SetElementName(nameof(Restaurant.ContactNumber))
                .SetOrder(7);

            // Map Address as a complex type
            classMap.MapMember(r => r.Address)
                .SetElementName(nameof(Restaurant.Address))
                .SetSerializer(new BsonClassMapSerializer<Address>(BsonClassMap.LookupClassMap(typeof(Address))))
                .SetOrder(8);

            // Map Dishes as a complex type (Array of Dish)
            classMap.MapMember(r => r.Dishes)
                .SetElementName(nameof(Restaurant.Dishes))
                .SetSerializer(new ArraySerializer<Dish>(new BsonClassMapSerializer<Dish>(BsonClassMap.LookupClassMap(typeof(Dish)))))
                .SetOrder(9);
        });
    }
}
