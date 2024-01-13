
namespace wallet.Domain.Entities
{
    public class Currency : EntityBase
    {
        public string CurrencyName  { get; set; }
        public string Symbol { get; set; }
        public IEnumerable<string> Validate()
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(CurrencyName))
            {
                errors.Add("CurrencyName is required");
            }

            if (string.IsNullOrWhiteSpace(Symbol))
            {
                errors.Add("Symbol is required");
            }

            return errors;
        }

    }


}
