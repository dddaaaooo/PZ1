using System;
using System.Collections.Generic;

namespace PZ1_ZyryanovaDA.Models;

public partial class User
{
    public long Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<UsersDetail> UsersDetails { get; set; } = new List<UsersDetail>();
}
