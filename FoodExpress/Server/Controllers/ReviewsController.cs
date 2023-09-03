using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodExpress.Server.Data;
using FoodExpress.Shared;
using FoodExpress.Server.Services.ReviewService;

namespace FoodExpress.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _service;

        public ReviewsController(IReviewService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviews()
        {
          return await _service.GetReviews();
        }

        public async Task<ActionResult<Review>> PostReview(Review review)
        {
          return await _service.PostReview(review);
        }        
    }
}
