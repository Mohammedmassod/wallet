
namespace wallet.Domain.Entities
{
    public class Service:EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ProviderId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        #region Relations

       // public ICollection<Order> Orders { get; set; }

        #endregion
    }
}
