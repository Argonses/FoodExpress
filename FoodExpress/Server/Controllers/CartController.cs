﻿using FoodExpress.Server.Services.CartService;
using FoodExpress.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodExpress.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _service;

        public CartController(ICartService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Order>> GetOrders()
        {
            return await _service.GetOrders();
        }
    }
}