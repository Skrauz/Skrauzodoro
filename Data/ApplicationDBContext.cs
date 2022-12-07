using Microsoft.EntityFrameworkCore;
using SkrauzodoroTimer.Models;

namespace SkrauzodoroTimer.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<TimeWindow>? TimeWindows { get; set; }
}