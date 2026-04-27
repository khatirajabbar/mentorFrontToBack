using WebApplication2.Models;

namespace WebApplication2.Data;

public static class DbSeeder
{
    public static void Seed(AppDbContext db)
    {
        if (db.Trainers.Any()) return; // already seeded, skip

        var trainers = new List<Trainer>
        {
            new Trainer
            {
                FullName = "Walter White",
                Title = "Chemistry Professor",
                Bio = "Experienced chemistry teacher with over 15 years in education.",
                PhotoUrl = "assets/img/trainers/trainer-1.jpg",
                Twitter = "https://twitter.com",
                LinkedIn = "https://linkedin.com"
            },
            new Trainer
            {
                FullName = "Sarah Johnson",
                Title = "Web Development Instructor",
                Bio = "Full stack developer and passionate educator.",
                PhotoUrl = "assets/img/trainers/trainer-2.jpg",
                Twitter = "https://twitter.com",
                LinkedIn = "https://linkedin.com"
            },
            new Trainer
            {
                FullName = "Mark Davis",
                Title = "Design Lead",
                Bio = "UI/UX designer with a love for teaching creative skills.",
                PhotoUrl = "assets/img/trainers/trainer-3.jpg",
                Twitter = "https://twitter.com",
                LinkedIn = "https://linkedin.com"
            }
        };

        db.Trainers.AddRange(trainers);
        db.SaveChanges();

        var courses = new List<Course>
        {
            new Course
            {
                Title = "Website Design",
                Description = "Learn modern web design from scratch using HTML, CSS and Bootstrap.",
                ImageUrl = "assets/img/course/course-1.webp",
                Price = 120,
                Duration = "3 months",
                Category = "Design",
                TrainerId = trainers[0].Id,
                IsActive = true
            },
            new Course
            {
                Title = "Search Engine Optimization",
                Description = "Master SEO techniques to rank your website on Google.",
                ImageUrl = "assets/img/course/course-2.webp",
                Price = 80,
                Duration = "6 weeks",
                Category = "Marketing",
                TrainerId = trainers[1].Id,
                IsActive = true
            },
            new Course
            {
                Title = "C# and ASP.NET Core",
                Description = "Build real web applications with C# and ASP.NET Core MVC.",
                ImageUrl = "assets/img/course/course-3.webp",
                Price = 150,
                Duration = "4 months",
                Category = "Development",
                TrainerId = trainers[2].Id,
                IsActive = true
            }
        };

        db.Courses.AddRange(courses);
        db.SaveChanges();

        var testimonials = new List<Testimonial>
        {
            new Testimonial
            {
                AuthorName = "Saul Goodman",
                AuthorTitle = "CEO & Founder",
                PhotoUrl = "assets/img/person/person-m-6.webp",
                Content = "Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus.",
                Rating = 5
            },
            new Testimonial
            {
                AuthorName = "Sara Wilsson",
                AuthorTitle = "Designer",
                PhotoUrl = "assets/img/person/person-f-3.webp",
                Content = "Export tempor illum tamen malis malis eram quae irure esse labore quem cillum quid cillum eram malis.",
                Rating = 5
            },
            new Testimonial
            {
                AuthorName = "Jena Karlis",
                AuthorTitle = "Store Owner",
                PhotoUrl = "assets/img/person/person-f-4.webp",
                Content = "Enim nisi quem export duis labore cillum quae magna enim sint quorum nulla quem veniam duis.",
                Rating = 5
            }
        };

        db.Testimonials.AddRange(testimonials);
        db.SaveChanges();

        var stats = new SiteStat
        {
            StudentCount = 1232,
            CourseCount = 64,
            TrainerCount = 16,
            AwardCount = 42
        };

        db.SiteStats.Add(stats);
        db.SaveChanges();
    }
}