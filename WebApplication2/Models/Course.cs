namespace WebApplication2.Models;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public decimal Price { get; set; }
    public string Duration { get; set; } = "";
    public string Category { get; set; } = "";
    public bool IsActive { get; set; } = true;
    public int TrainerId { get; set; }
    public Trainer? Trainer { get; set; }
}