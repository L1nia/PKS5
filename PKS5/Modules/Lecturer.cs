using System;
using System.Collections.Generic;

namespace PKS5.Modules;

public partial class Lecturer
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Middlename { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Department { get; set; } = null!;
}
