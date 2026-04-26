using WebApplication2.Models;

namespace WebApplication2.ViewModels;

public class CourseDetailsViewModel
{
    public Course Course { get; set; } = new();
    public Trainer? Trainer { get; set; }
}