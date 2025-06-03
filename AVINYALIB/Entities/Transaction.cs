using System;
using System.Collections.Generic;

namespace AVINYALIB.Entities;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int? FromAccountId { get; set; }

    public int? ToAccountId { get; set; }

    public string? Amount { get; set; }

    public string? Date { get; set; }

    public string? Status { get; set; }

    public virtual Account? FromAccount { get; set; }

    public virtual Account? ToAccount { get; set; }
    public string Name { get; internal set; }
    public string Email { get; internal set; }
    public string Password { get; internal set; }
    public string Role { get; internal set; }
    public int UserId { get; internal set; }
}
