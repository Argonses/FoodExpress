using FoodExpress.Shared;

namespace FoodExpress.Client.Services.ReviewService
{
    public interface IReviewService
    {
        List<Review> Reviews { get; set; }
        Task GetAllReviews();
        Task<Review> AddReview(Review review);
    }
}
