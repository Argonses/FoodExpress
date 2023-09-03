using FoodExpress.Shared;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace FoodExpress.Client.Services.ReviewService
{
    public class ReviewService : IReviewService
    {
        private readonly HttpClient _http;

        public ReviewService(HttpClient http)
        {
            _http = http;
        }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public async Task<Review> AddReview(Review review)
        {
            var result = await _http.PostAsJsonAsync<Review>("api/Reviews", review);
            return review;
        }

        public async Task GetAllReviews()
        {
            var result = await _http.GetFromJsonAsync<List<Review>>("api/Reviews");
            if (result != null)
            {
                Reviews = result;
            }
        }
    }
}
