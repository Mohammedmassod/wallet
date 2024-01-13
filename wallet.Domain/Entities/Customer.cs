using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet.Domain.Entities
{
    // Customer entity
    public class Customer : EntityBase
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        // Navigation properties for relationships
       // public ICollection<Account> Accounts { get; set; }
    }
}
