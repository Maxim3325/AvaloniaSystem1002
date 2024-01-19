using System;
using System.Collections.Generic;

namespace AvaloniaSystem1002.Data;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int CategoryId { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public int MaxListeners { get; set; }

    public int TeacherId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<ListenersCourse> ListenersCourses { get; } = new List<ListenersCourse>();

    public virtual User Teacher { get; set; } = null!;
}
