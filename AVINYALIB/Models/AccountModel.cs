﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVINYALIB.Models
{
    public class AccountModel
    {
        public int AccountId { get; set; }
        public int? UserId { get; set; }
        public string? AccountNumber { get; set; }
        public string? Balance { get; set; }
    }
}
