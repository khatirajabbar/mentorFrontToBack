using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<ContactMessage> ContactMessages { get; set; }
    public DbSet<SiteStat> SiteStats { get; set; }
}