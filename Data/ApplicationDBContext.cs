using Microsoft.EntityFrameworkCore;
using SkrauzodoroTimer.Models;

namespace SkrauzodoroTimer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<TimeWindow>? TimeWindows { get; set; }
    }
}