using Microsoft.EntityFrameworkCore;
using DevFeedbackAPI.Models;

namespace DevFeedbackAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
