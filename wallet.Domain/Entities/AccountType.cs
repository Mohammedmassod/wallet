

using System.Xml.Linq;

namespace wallet.Domain.Entities
{
    public class AccountType : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Validate()
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(Name))
            {
                errors.Add("Name is required");
            }

            if (string.IsNullOrWhiteSpace(Description))
            {
                errors.Add("Description is required");
            }

            return errors;
        }
    

}

}