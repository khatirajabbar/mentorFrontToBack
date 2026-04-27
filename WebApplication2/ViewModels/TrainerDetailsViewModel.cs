using WebApplication2.Models;

namespace WebApplication2.ViewModels;

public class TrainerDetailsViewModel
{
    public Trainer Trainer { get; set; } = new();
    public List<Course> Courses { get; set; } = new();
}