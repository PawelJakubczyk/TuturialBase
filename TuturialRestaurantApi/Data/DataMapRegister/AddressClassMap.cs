using MongoDB.Bson.Serialization;
using TutorialRestaurantApi.Entities;

namespace TuturialRestaurantApi.Data;

// Registering a class for mapping for the Entities/Address class
public static class AddressClassMap
{
    public static void Register()
    {
        BsonClassMap.RegisterClassMap<Address>(classMap =>
        {
            classMap.MapMember(a => a.AddressID)
                .SetElementName("AddressID")
                .SetOrder(1);

            classMap.MapMember(a => a.City)
                .SetElementName("City")
                .SetOrder(2);

            classMap.MapMember(a => a.Street)
                .SetElementName("Street")
                .SetOrder(3);

            classMap.MapMember(a => a.PostalCode)
                .SetElementName("PostalCode")
                .SetOrder(4);
        });
    }
}

