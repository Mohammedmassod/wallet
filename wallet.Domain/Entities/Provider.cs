
namespace wallet.Domain.Entities
{
    public class Provider :EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
