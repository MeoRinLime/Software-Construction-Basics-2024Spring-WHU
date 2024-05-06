using OrderManage;
using System;
using System.Text;


namespace OrderManage
{
    public class Order : IComparable<Order>
    {
        private readonly List<OrderDetail> details = new List<OrderDetail>();
        private static HashSet<int> existingIds = new HashSet<int>();
        private static Random random = new Random();
        public int OrderId { get; set; }

        public string Customer { get; set; }

        public DateTime CreateTime { get; set; }

/*        public float TotalPrice
        {
            get
            {
                return Details.Sum(d => d.Quantity * d.Goods.Price);
            }
        }*/


        public List<OrderDetail> Details => details;

        public Order(string customer)
        {
            this.OrderId = GenerateUniqueId();
            this.Customer = customer;
            this.CreateTime = DateTime.Now;
        }

        private int GenerateUniqueId()
        {
            int id = 0;
            lock (random) // 确保线程安全
            {
                do
                {
                    id = random.Next(10, 10000000); 
                } while (existingIds.Contains(id)); // 检查是否唯一

                existingIds.Add(id); // 将新生成的 ID 添加到已有 ID 集合中
            }
            return id;
        }

        public void AddDetails(OrderDetail orderDetail)
        {
            Details.Add(orderDetail);
        }

        public int CompareTo(Order other)
        {
            return (other == null) ? 1 : OrderId - other.OrderId;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            return OrderId.GetHashCode();
        }

        public void RemoveDetails(int num)
        {
            Details.RemoveAt(num);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"orderId:{OrderId}, customer:({Customer})");
            Details.ForEach(detail => result.Append("\n\t" + detail));
            return result.ToString();
        }

    }
}
