using System;
using System.Collections.Generic;

namespace AVINYALIB.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? PasswordHash { get; set; }

    public string? Role { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
