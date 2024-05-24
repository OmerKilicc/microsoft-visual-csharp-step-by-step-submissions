using System;
using System.Collections.Generic;

namespace DataTypes
{
	public class Order
    {
        public Guid OrderID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
