

namespace wallet.Domain.Entities
{
    public class Product: EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int ProviderId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }


        
    }
}
