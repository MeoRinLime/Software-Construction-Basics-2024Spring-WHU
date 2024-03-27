using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagement
{
    internal class OrderDetails
    {
        public int Quantity { get; set; }
        public required string Customer { get; set; }
        public required string NameOfMerchandise { get; set; }
        public decimal UnitPrice { get; set; }

        public OrderDetails(int quantity, string customer, string nameOfMerchandise, decimal UnitPrice)
        {
            this.Quantity = quantity;
            this.Customer = customer;
            this.NameOfMerchandise = nameOfMerchandise;
            this.UnitPrice = UnitPrice;
        }

        public bool Equals(OrderDetails other)
        {
            if (other == null) return false;
            return this.Customer == other.Customer && this.Quantity == other.Quantity && this.NameOfMerchandise == other.NameOfMerchandise && this.UnitPrice == other.UnitPrice;
        }

        public override string ToString()
        {
            return $"Customer: {Customer}\r\n Quantity: {Quantity}\r\n Merchandise: {NameOfMerchandise}\r\n UnitPrice: {UnitPrice}";
        }
    }
}
