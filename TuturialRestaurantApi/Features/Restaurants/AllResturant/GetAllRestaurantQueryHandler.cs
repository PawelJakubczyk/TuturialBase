﻿using MediatR;
using MongoDB.Driver;
using TutorialRestaurantBase.Entities;
using TuturialRestaurantBase.Data;

public sealed class GetAllRestaurantQueryHandler : IRequestHandler<GetAllRestaurantQuery, Restaurant>
{
    private readonly IRestaurantContext _restaurantContext;

    public GetAllRestaurantQueryHandler(IRestaurantContext restaurantContext)
    {
        _restaurantContext = restaurantContext;
    }

    public async Task<Restaurant> Handle(GetAllRestaurantQuery query, CancellationToken cancellationToken)
    {
        return await _restaurantContext.Restaurants.Find(FilterDefinition<Restaurant>.Empty).FirstOrDefaultAsync(cancellationToken);
    }
}