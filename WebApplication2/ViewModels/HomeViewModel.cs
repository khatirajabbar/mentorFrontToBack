using WebApplication2.Models;

namespace WebApplication2.ViewModels;

public class HomeViewModel
{
    public List<Course> Courses { get; set; } = new();
    public List<Trainer> Trainers { get; set; } = new();
    public List<Testimonial> Testimonials { get; set; } = new();
    public SiteStat? Stats { get; set; }
}