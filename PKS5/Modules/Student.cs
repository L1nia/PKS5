using System;
using System.Collections.Generic;

namespace PKS5.Modules;

public partial class Student
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fio { get; set; } = null!;
}
