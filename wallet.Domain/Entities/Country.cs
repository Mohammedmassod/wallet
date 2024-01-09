using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet.Domain.Entities
{
    // Country entity
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        // Other relevant properties for country
    }

}
