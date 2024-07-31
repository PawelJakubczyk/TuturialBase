﻿using MediatR;
using TuturialRestaurantApi.Domain.Entities;

namespace TuturialRestaurantApi.Application.Features.Restaurants;
public sealed record UpdateRestaurantCommand(string Id) : IRequest<string>;
