using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityInNTierNetCore.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
