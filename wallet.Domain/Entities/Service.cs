﻿using System;
using System.Collections.Generic;

namespace wallet.Domain.Entities
{
    public class Service:EntityBase
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        #region Relations

        public ICollection<Order> Orders { get; set; }

        #endregion
    }
}
