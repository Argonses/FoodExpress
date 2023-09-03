using FoodExpress.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FoodExpress.Server.Services.ReviewService
{
    public interface IReviewService
    {
        Task<ActionResult<IEnumerable<Review>>> GetReviews();
        Task<ActionResult<Review>> PostReview(Review review);
    }
}
