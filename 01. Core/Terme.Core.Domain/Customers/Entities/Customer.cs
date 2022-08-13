using System.Collections.Generic;
using Terme.Core.Domain.Orders.Entities;
using Terme.Framework.Domain;

namespace Terme.Core.Domain.Customers.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public List<Order> Orders { get; set; }
        public List<Payment> Payments { get; set; }
        public List<CustomerContact> CustomerContacts { get; set; }
    }
}
