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
        review.Id = reviews.Max(x => x.Id) + 1;
        reviews.Add(review);
    }
}