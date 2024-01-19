using System;
using System.Collections.Generic;

namespace AvaloniaSystem1002.Data;

public partial class Mark
{
    public int Id { get; set; }

    public int Value { get; set; }

    public DateTime PlaceTime { get; set; }

    public int ListenerCourseId { get; set; }

    public virtual ListenersCourse ListenerCourse { get; set; } = null!;
}
