﻿using MediatR;
using TuturialRestaurantApi.Data.DataContext;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;

public sealed record AddRestaurantCommand(Restaurant Restaurant) : IRequest<Restaurant>;