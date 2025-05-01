namespace TeaReviews;

public class ReviewModel
{
    public int Id { get; set; }
    public string TeaName { get; set; } = "";
    public int Rating { get; set; }
    public string Message { get; set; } = "";
    public string Url { get; set; } = "";
}