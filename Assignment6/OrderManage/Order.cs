using OrderManage;
using System.Text;

namespace OrderApp
{

    /**
     **/
    public class Order : IComparable<Order>
    {
        private readonly List<OrderDetail> details = new List<OrderDetail>();
        public int Id { get; set; }

        public string Customer { get; set; }

        public DateTime CreateTime { get; set; }

        public float TotalPrice
        {
            get => Details.Sum(d => d.TotalPrice);
        }

        public List<OrderDetail> Details => details;

        public Order()
        {
            CreateTime = DateTime.Now;
        }

        //id号为随机生成的七位数字
        public Order(string customer)
        {
            Random random = new Random();
            int id = 0;
            do
            {
                id = random.Next(1000000, 10000000);
            } while (GlobalVariables.ordersID.Contains(id));
            GlobalVariables.ordersID.Add(id);
            this.Id = id;
            Customer = customer;
            CreateTime = DateTime.Now;
        }

        public void AddDetails(OrderDetail orderDetail)
        {
            if (Details.Contains(orderDetail))
            {
                throw new ApplicationException($"The goods ({orderDetail.Goods.Name}) exist in order {Id}");
            }
            Details.Add(orderDetail);
        }

        public int CompareTo(Order other)
        {
            return (other == null) ? 1 : Id - other.Id;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && Id == order.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public void RemoveDetails(int num)
        {
            Details.RemoveAt(num);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"orderId:{Id}, customer:({Customer})");
            Details.ForEach(detail => result.Append("\n\t" + detail));
            return result.ToString();
        }

    }
}
