using Microsoft.AspNetCore.Mvc;

namespace TeaReviews;

[ApiController]
[Route("/")]
public class ReviewController
{
    private static List<ReviewModel> reviews { get; set; } = [];

    [HttpGet]
    public List<ReviewModel> GetReviews()
    {
        return reviews;
    }

    [HttpPost]
    public void PostReview([FromBody] ReviewModel review)
    {
        reviews.Add(review);
    }
}