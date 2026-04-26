namespace WebApplication2.Models;

public class Trainer
{
    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string Title { get; set; } = "";
    public string Bio { get; set; } = "";
    public string PhotoUrl { get; set; } = "";
    public string Twitter { get; set; } = "";
    public string LinkedIn { get; set; } = "";
    public List<Course> Courses { get; set; } = new();
}