﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet.Domain.Entities
{
    // Account entity
    public class Account
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public decimal Balance { get; set; }
    }
}
