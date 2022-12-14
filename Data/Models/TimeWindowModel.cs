using System.ComponentModel.DataAnnotations;

namespace SkrauzodoroTracker.Models;

public class TimeWindow
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = "Unnamed";

    public DateTime StartTime { get; set; } = DateTime.Now;

    public DateTime? EndTime { get; set; }

    public TimeSpan? Length {get; set;}

    public bool IsTracked {get; set;}

    // eventually add in pomodoro implementation in an update later
    /* public List<IPomoWindow>? PomoComposition {get; set;} */
}