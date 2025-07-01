using System;
using System.Collections.Generic;

namespace api.net.template.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }
}
