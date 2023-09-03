using FoodExpress.Server.Data;
using FoodExpress.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodExpress.Server.Services.ReviewService
{
    public class ReviewService : IReviewService
    {
        private readonly ApplicationDbContext _context;

        public ReviewService(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviews()
        {
            if (_context.Reviews == null)
            {
                return null;
            }
            return await _context.Reviews.ToListAsync();
        }

        public async Task<ActionResult<Review>> PostReview(Review review)
        {
            if (_context.Reviews == null)
            {
                return null;
            }
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            return review;
        }
    }
}
