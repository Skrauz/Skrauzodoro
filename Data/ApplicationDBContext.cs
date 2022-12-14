using Microsoft.EntityFrameworkCore;
using SkrauzodoroTracker.Models;

namespace SkrauzodoroTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<TimeWindow>? TimeWindows { get; set; }
    }
}