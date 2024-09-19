using System;
using System.Collections.Generic;

namespace PZ1_ZyryanovaDA.Models;

public partial class UsersDetail
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public virtual User User { get; set; } = null!;
}
