using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagement
{
    internal class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (orders.Any(o => o.Equals(order)))
            {
                throw new Exception("Order already exists.");
            }
            orders.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                throw new Exception("Order not found.");
            }
            orders.Remove(order);
        }

        public void UpdateOrder(Order order)
        {
            var existingOrder = orders.FirstOrDefault(o => o.OrderId == order.OrderId);
            if (existingOrder == null)
            {
                throw new Exception("Order not found.");
            }
            orders.Remove(existingOrder);
            orders.Add(order);
        }

        public IEnumerable<Order> QueryOrders(Func<Order, bool> predicate)
        {
            return orders.Where(predicate).OrderBy(o => o.OrderId);
        }

        public void SortOrders(Func<Order, object> keySelector = null)
        {
            if (keySelector == null)
            {
                orders = orders.OrderBy(o => o.OrderId).ToList();
            }
            else
            {
                orders = orders.OrderBy(keySelector).ToList();
            }
        }

        public void DisplayOrders()
        {
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }

        public void DisplayOrdersWithAllDetails()
        {
            foreach (var order in orders)
            {
                Console.WriteLine(order);
                Console.WriteLine(order.OrderDetails);
            }
        }
    }
}
