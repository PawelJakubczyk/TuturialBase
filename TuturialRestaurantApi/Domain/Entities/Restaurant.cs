namespace TuturialRestaurantApi.Domain.Entities;

public class Restaurant
{
    public string Id { get; set; }
    public string RestaurantName { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public bool HasDelivery { get; set; }
    public string ContactEmail { get; set; }
    public string ContactNumber { get; set; }
    public Address Address { get; set; }
    public Dish[] Dishes { get; set; }
}