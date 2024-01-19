using System;
using System.Collections.Generic;

namespace AvaloniaSystem1002.Data;

public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Foto { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; } = new List<Course>();

    public virtual ICollection<ListenersCourse> ListenersCourses { get; } = new List<ListenersCourse>();

    public virtual Role Role { get; set; } = null!;
}
