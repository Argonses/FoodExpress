﻿using FoodExpress.Shared;

namespace FoodExpress.Server.Services.CartService
{
    public interface ICartService
    {
        Task<List<Order>> GetOrders();
    }
}