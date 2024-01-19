using System;
using System.Collections.Generic;

namespace AvaloniaSystem1002.Data;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; } = new List<Course>();
}
