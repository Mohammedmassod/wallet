using System;

namespace wallet.Domain.Entities
{
    public abstract class EntityBase
    {
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
