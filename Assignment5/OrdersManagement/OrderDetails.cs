using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagement
{
    internal class OrderDetails(int quantity, string customer, string nameOfMerchandise, decimal UnitPrice)
    {
        public int Quantity { get; set; } = quantity;
        public string? Customer { get; set; } = customer;
        public string? NameOfMerchandise { get; set; } = nameOfMerchandise;
        public decimal UnitPrice { get; set; } = UnitPrice;

        public bool Equals(OrderDetails other)
        {
            if (other == null) return false;
            return this.Customer == other.Customer && this.Quantity == other.Quantity && this.NameOfMerchandise == other.NameOfMerchandise && this.UnitPrice == other.UnitPrice;
        }

        public override string ToString()
        {
            return $"Customer: {Customer}\nQuantity: {Quantity}\nMerchandise: {NameOfMerchandise}\nUnitPrice: {UnitPrice}\n";
        }
    }
}
