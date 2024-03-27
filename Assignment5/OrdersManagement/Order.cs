using OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagement
{
    internal class Order : IEquatable<Order>
    {
        public int OrderId { get; set; }

        public OrderDetails? OrderDetails { get; set; }

        public decimal TotalAmount => OrderDetails.UnitPrice * OrderDetails.Quantity;

        public Order(int orderId, OrderDetails orderDetails)
        {
            this.OrderId = orderId;
            this.OrderDetails = orderDetails;
        }

        public bool Equals(Order other)
        {
            if (other == null) return false;
            return this.OrderId == other.OrderId;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderId}\r\n Total Amount: {TotalAmount}";
        }
    }
}
