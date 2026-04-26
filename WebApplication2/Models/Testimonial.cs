namespace WebApplication2.Models;

public class Testimonial
{
    public int Id { get; set; }
    public string AuthorName { get; set; } = "";
    public string AuthorTitle { get; set; } = "";
    public string PhotoUrl { get; set; } = "";
    public string Content { get; set; } = "";
    public int Rating { get; set; }
}