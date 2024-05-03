using System;
using System.Collections.Generic;

namespace PKS5.Modules;

public partial class Achievement
{
    public DateOnly Date { get; set; }

    public string Type { get; set; } = null!;

    public int Id { get; set; }

    public string Description { get; set; } = null!;
}
