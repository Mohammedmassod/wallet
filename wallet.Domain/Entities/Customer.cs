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
        public int Customerint{ get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        // Navigation properties for relationships
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
