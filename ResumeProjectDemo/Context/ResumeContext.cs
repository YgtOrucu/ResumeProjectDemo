using Microsoft.EntityFrameworkCore;
using ResumeProjectDemo.Entities;

namespace ResumeProjectDemo.Context
{
    public class ResumeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YIGITORUCU\\MY_YAZILIM_KURSU;Initial Catalog=DB_Project1_ResumeProjectDemo;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skills> Skills { get; set; }

    }
}
