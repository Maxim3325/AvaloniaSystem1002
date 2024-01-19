using System;
using System.Collections.Generic;

namespace AvaloniaSystem1002.Data;

public partial class ListenersCourse
{
    public int Id { get; set; }

    public int CourseId { get; set; }

    public int ListenerId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual User Listener { get; set; } = null!;

    public virtual ICollection<Mark> Marks { get; } = new List<Mark>();
}
